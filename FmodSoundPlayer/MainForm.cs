using FmodAudio;
using FmodSoundPlayer.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FmodSoundPlayer
{
    public partial class MainForm : Form
    {
        private readonly FmodSystem fmodSystem;
        private Channel currentChannel;
        private int lastItemIndex;
        private Stopwatch playStopwatch;
        private static readonly string[] ValidExtensions =
        {
            "wav",
            "ogg",
            "mp3"
        };

        public MainForm()
        {
            InitializeComponent();
            try
            {
                fmodSystem = Fmod.CreateSystem();
                fmodSystem.Init(10);
                UpdateTimer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load FMOD sound system - make sure the correct DLL is in the executable folder - " + ex.Message);
            }

            var dir = Settings.Default.LastDirectory;
            if (!string.IsNullOrWhiteSpace(dir))
            {
                DirectoryTextBox.Text = dir;
                DirectoryBrowser.SelectedPath = dir;
                PopulateSoundList(dir);
            }
            VolumeScrollBar_Scroll(this, null);
            PitchScrollBar_Scroll(this, null);
            SoundList.Focus();
        }

        private void VolumeScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            VolumeLabel.Text = $"Volume: {VolumeScrollBar.Value}";
        }

        private void PitchScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

            PitchLabel.Text = $"Pitch: {PitchScrollBar.Value}";
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            var result = DirectoryBrowser.ShowDialog();
            var path = DirectoryBrowser.SelectedPath;
            if (result == DialogResult.Cancel || string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            DirectoryTextBox.Text = path;
            Settings.Default.LastDirectory = path;
            PopulateSoundList(path);
            SoundList.Focus();
            lastItemIndex = -2;
        }

        private void PopulateSoundList(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            var files = Directory.GetFiles(path)
                .Where(f => ValidExtensions.Any(ext => f.EndsWith($".{ext}")))
                .Select(f => Path.GetFileName(f));

            SoundList.Items.Clear();
            SoundList.Items.AddRange(files.ToArray());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            fmodSystem.Update();
            var stopwatchActive = playStopwatch != null && playStopwatch.IsRunning;
            if (!stopwatchActive) return;

            var elapsed = playStopwatch.Elapsed;
            LengthLabel.Text = $"Length: {elapsed.TotalSeconds:F2}s";
            var soundPlaying = currentChannel != null && currentChannel.IsPlaying;
            if (!soundPlaying)
            {
                playStopwatch.Stop();
                playStopwatch = null;
            }
        }

        private void PlaySound()
        {
            StopSound();

            if (SoundList.SelectedItem is not string selectedItem)
            {
                return;
            }

            lastItemIndex = SoundList.SelectedIndex;

            var fullPath = Path.Combine(DirectoryTextBox.Text, selectedItem);
            var sound = LoadFmodSound(fullPath);

            currentChannel = fmodSystem.PlaySound(sound.Value, paused: true);
            currentChannel.Pitch = PitchScrollBar.Value / 100.0f;
            currentChannel.Volume = VolumeScrollBar.Value / 100.0f;
            currentChannel.Paused = false;
            playStopwatch = new Stopwatch();
            playStopwatch.Start();
        }

        private void StopSound()
        {
            if (currentChannel == null || !currentChannel.IsPlaying)
            {
                currentChannel = null;
                return;
            }

            currentChannel.Stop();
            currentChannel = null;
        }

        private Sound? LoadFmodSound(string fullPath)
        {
            return fmodSystem.CreateSound(fullPath, Mode._2D | Mode.Loop_Off);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (SoundList.SelectedIndex == lastItemIndex && currentChannel != null && currentChannel.IsPlaying)
            {
                return;
            }

            PlaySound();
        }

        private void SoundList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopSound();
        }

        private void SoundList_KeyDown(object sender, KeyEventArgs e)
        {
            if (SoundList.SelectedItem == null || !e.Control || e.KeyCode != Keys.C) return;
            Clipboard.SetText(SoundList.SelectedItem.ToString());
            e.SuppressKeyPress = true;
            e.Handled = true;
        }
    }
}
