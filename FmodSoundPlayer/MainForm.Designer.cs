
namespace FmodSoundPlayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SoundList = new System.Windows.Forms.ListBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeScrollBar = new System.Windows.Forms.HScrollBar();
            this.PitchScrollBar = new System.Windows.Forms.HScrollBar();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(13, 13);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(55, 15);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Directory";
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(75, 13);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(293, 23);
            this.DirectoryTextBox.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(380, 13);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(37, 23);
            this.DirectoryButton.TabIndex = 2;
            this.DirectoryButton.Text = "...";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // DirectoryBrowser
            // 
            this.DirectoryBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SoundList
            // 
            this.SoundList.FormattingEnabled = true;
            this.SoundList.ItemHeight = 15;
            this.SoundList.Location = new System.Drawing.Point(12, 54);
            this.SoundList.Name = "SoundList";
            this.SoundList.Size = new System.Drawing.Size(405, 334);
            this.SoundList.TabIndex = 3;
            this.SoundList.SelectedIndexChanged += new System.EventHandler(this.SoundList_SelectedIndexChanged);
            this.SoundList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoundList_KeyDown);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(12, 394);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(47, 15);
            this.VolumeLabel.TabIndex = 4;
            this.VolumeLabel.Text = "Volume";
            // 
            // VolumeScrollBar
            // 
            this.VolumeScrollBar.Location = new System.Drawing.Point(13, 418);
            this.VolumeScrollBar.Maximum = 200;
            this.VolumeScrollBar.Name = "VolumeScrollBar";
            this.VolumeScrollBar.Size = new System.Drawing.Size(120, 23);
            this.VolumeScrollBar.TabIndex = 5;
            this.VolumeScrollBar.Value = 100;
            this.VolumeScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeScrollBar_Scroll);
            // 
            // PitchScrollBar
            // 
            this.PitchScrollBar.Location = new System.Drawing.Point(147, 418);
            this.PitchScrollBar.Maximum = 500;
            this.PitchScrollBar.Name = "PitchScrollBar";
            this.PitchScrollBar.Size = new System.Drawing.Size(120, 23);
            this.PitchScrollBar.TabIndex = 7;
            this.PitchScrollBar.Value = 100;
            this.PitchScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PitchScrollBar_Scroll);
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(147, 394);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(34, 15);
            this.PitchLabel.TabIndex = 6;
            this.PitchLabel.Text = "Pitch";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(281, 418);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(65, 23);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 1;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(352, 418);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(65, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(281, 394);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(76, 15);
            this.LengthLabel.TabIndex = 10;
            this.LengthLabel.Text = "Length: 0.00s";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PitchScrollBar);
            this.Controls.Add(this.PitchLabel);
            this.Controls.Add(this.VolumeScrollBar);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.SoundList);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.DirectoryLabel);
            this.Name = "MainForm";
            this.Text = "FMOD Sound Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog DirectoryBrowser;
        private System.Windows.Forms.ListBox SoundList;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.HScrollBar VolumeScrollBar;
        private System.Windows.Forms.HScrollBar PitchScrollBar;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label LengthLabel;
    }
}

