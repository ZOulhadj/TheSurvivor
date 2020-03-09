namespace TheSurvivor.Forms
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.difficultySlider = new System.Windows.Forms.TrackBar();
            this.easyLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.impossibleLabel = new System.Windows.Forms.Label();
            this.toggleSoundButton = new System.Windows.Forms.Button();
            this.toggleMusicLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gameplayTab = new System.Windows.Forms.TabPage();
            this.rangerOption = new System.Windows.Forms.RadioButton();
            this.fighterOption = new System.Windows.Forms.RadioButton();
            this.explorerOption = new System.Windows.Forms.RadioButton();
            this.bomberOption = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.soundTab = new System.Windows.Forms.TabPage();
            this.soundLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.customLabel = new System.Windows.Forms.Label();
            this.staticPlatformsTextbox = new System.Windows.Forms.TextBox();
            this.movingPlatformsTextbox = new System.Windows.Forms.TextBox();
            this.staticPlatformsLabel = new System.Windows.Forms.Label();
            this.movingPlatformsLabel = new System.Windows.Forms.Label();
            this.playerSpeedLabel = new System.Windows.Forms.Label();
            this.playerSpeedTextbox = new System.Windows.Forms.TextBox();
            this.performanceWarningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficultySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.gameplayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.soundTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(366, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // difficultySlider
            // 
            this.difficultySlider.LargeChange = 1;
            this.difficultySlider.Location = new System.Drawing.Point(98, 6);
            this.difficultySlider.Maximum = 5;
            this.difficultySlider.Minimum = 1;
            this.difficultySlider.Name = "difficultySlider";
            this.difficultySlider.Size = new System.Drawing.Size(276, 45);
            this.difficultySlider.TabIndex = 3;
            this.difficultySlider.Value = 1;
            this.difficultySlider.Scroll += new System.EventHandler(this.difficultySlider_Scroll);
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.Location = new System.Drawing.Point(95, 38);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(30, 13);
            this.easyLabel.TabIndex = 4;
            this.easyLabel.Text = "Easy";
            // 
            // mediumLabel
            // 
            this.mediumLabel.AutoSize = true;
            this.mediumLabel.Location = new System.Drawing.Point(153, 38);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(44, 13);
            this.mediumLabel.TabIndex = 5;
            this.mediumLabel.Text = "Medium";
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.Location = new System.Drawing.Point(220, 38);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(30, 13);
            this.hardLabel.TabIndex = 6;
            this.hardLabel.Text = "Hard";
            // 
            // impossibleLabel
            // 
            this.impossibleLabel.AutoSize = true;
            this.impossibleLabel.Location = new System.Drawing.Point(267, 38);
            this.impossibleLabel.Name = "impossibleLabel";
            this.impossibleLabel.Size = new System.Drawing.Size(56, 13);
            this.impossibleLabel.TabIndex = 7;
            this.impossibleLabel.Text = "Impossible";
            // 
            // toggleSoundButton
            // 
            this.toggleSoundButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSoundButton.Location = new System.Drawing.Point(6, 14);
            this.toggleSoundButton.Name = "toggleSoundButton";
            this.toggleSoundButton.Size = new System.Drawing.Size(132, 27);
            this.toggleSoundButton.TabIndex = 8;
            this.toggleSoundButton.Text = "Toggle Sound";
            this.toggleSoundButton.UseVisualStyleBackColor = true;
            this.toggleSoundButton.Click += new System.EventHandler(this.toggleMusicButton_Click);
            // 
            // toggleMusicLabel
            // 
            this.toggleMusicLabel.AutoSize = true;
            this.toggleMusicLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleMusicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toggleMusicLabel.Location = new System.Drawing.Point(144, 18);
            this.toggleMusicLabel.Name = "toggleMusicLabel";
            this.toggleMusicLabel.Size = new System.Drawing.Size(32, 19);
            this.toggleMusicLabel.TabIndex = 9;
            this.toggleMusicLabel.Text = "On";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(148, 48);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(181, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gameplayTab);
            this.tabControl1.Controls.Add(this.soundTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 343);
            this.tabControl1.TabIndex = 12;
            // 
            // gameplayTab
            // 
            this.gameplayTab.BackColor = System.Drawing.SystemColors.Control;
            this.gameplayTab.Controls.Add(this.performanceWarningLabel);
            this.gameplayTab.Controls.Add(this.playerSpeedLabel);
            this.gameplayTab.Controls.Add(this.playerSpeedTextbox);
            this.gameplayTab.Controls.Add(this.movingPlatformsLabel);
            this.gameplayTab.Controls.Add(this.staticPlatformsLabel);
            this.gameplayTab.Controls.Add(this.movingPlatformsTextbox);
            this.gameplayTab.Controls.Add(this.staticPlatformsTextbox);
            this.gameplayTab.Controls.Add(this.customLabel);
            this.gameplayTab.Controls.Add(this.rangerOption);
            this.gameplayTab.Controls.Add(this.fighterOption);
            this.gameplayTab.Controls.Add(this.explorerOption);
            this.gameplayTab.Controls.Add(this.bomberOption);
            this.gameplayTab.Controls.Add(this.pictureBox4);
            this.gameplayTab.Controls.Add(this.pictureBox3);
            this.gameplayTab.Controls.Add(this.pictureBox2);
            this.gameplayTab.Controls.Add(this.pictureBox1);
            this.gameplayTab.Controls.Add(this.label1);
            this.gameplayTab.Controls.Add(this.difficultyLabel);
            this.gameplayTab.Controls.Add(this.easyLabel);
            this.gameplayTab.Controls.Add(this.mediumLabel);
            this.gameplayTab.Controls.Add(this.impossibleLabel);
            this.gameplayTab.Controls.Add(this.hardLabel);
            this.gameplayTab.Controls.Add(this.difficultySlider);
            this.gameplayTab.Location = new System.Drawing.Point(4, 22);
            this.gameplayTab.Name = "gameplayTab";
            this.gameplayTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameplayTab.Size = new System.Drawing.Size(768, 317);
            this.gameplayTab.TabIndex = 0;
            this.gameplayTab.Text = "Gameplay";
            // 
            // rangerOption
            // 
            this.rangerOption.AutoSize = true;
            this.rangerOption.Location = new System.Drawing.Point(640, 176);
            this.rangerOption.Name = "rangerOption";
            this.rangerOption.Size = new System.Drawing.Size(60, 17);
            this.rangerOption.TabIndex = 21;
            this.rangerOption.Text = "Ranger";
            this.rangerOption.UseVisualStyleBackColor = true;
            // 
            // fighterOption
            // 
            this.fighterOption.AutoSize = true;
            this.fighterOption.Location = new System.Drawing.Point(640, 123);
            this.fighterOption.Name = "fighterOption";
            this.fighterOption.Size = new System.Drawing.Size(57, 17);
            this.fighterOption.TabIndex = 20;
            this.fighterOption.Text = "Fighter";
            this.fighterOption.UseVisualStyleBackColor = true;
            // 
            // explorerOption
            // 
            this.explorerOption.AutoSize = true;
            this.explorerOption.Location = new System.Drawing.Point(640, 70);
            this.explorerOption.Name = "explorerOption";
            this.explorerOption.Size = new System.Drawing.Size(63, 17);
            this.explorerOption.TabIndex = 19;
            this.explorerOption.Text = "Explorer";
            this.explorerOption.UseVisualStyleBackColor = true;
            // 
            // bomberOption
            // 
            this.bomberOption.AutoSize = true;
            this.bomberOption.Checked = true;
            this.bomberOption.Location = new System.Drawing.Point(641, 17);
            this.bomberOption.Name = "bomberOption";
            this.bomberOption.Size = new System.Drawing.Size(61, 17);
            this.bomberOption.TabIndex = 18;
            this.bomberOption.TabStop = true;
            this.bomberOption.Text = "Bomber";
            this.bomberOption.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TheSurvivor.Properties.Resources.Ranger;
            this.pictureBox4.Location = new System.Drawing.Point(707, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TheSurvivor.Properties.Resources.Fighter;
            this.pictureBox3.Location = new System.Drawing.Point(707, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheSurvivor.Properties.Resources.Explorer;
            this.pictureBox2.Location = new System.Drawing.Point(707, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheSurvivor.Properties.Resources.Bomber;
            this.pictureBox1.Location = new System.Drawing.Point(707, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spaceship";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(6, 6);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(73, 19);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // soundTab
            // 
            this.soundTab.BackColor = System.Drawing.SystemColors.Control;
            this.soundTab.Controls.Add(this.soundLabel);
            this.soundTab.Controls.Add(this.trackBar1);
            this.soundTab.Controls.Add(this.toggleSoundButton);
            this.soundTab.Controls.Add(this.toggleMusicLabel);
            this.soundTab.Location = new System.Drawing.Point(4, 22);
            this.soundTab.Name = "soundTab";
            this.soundTab.Padding = new System.Windows.Forms.Padding(3);
            this.soundTab.Size = new System.Drawing.Size(768, 317);
            this.soundTab.TabIndex = 1;
            this.soundTab.Text = "Sound";
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.Location = new System.Drawing.Point(6, 48);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(123, 19);
            this.soundLabel.TabIndex = 12;
            this.soundLabel.Text = "Sound Volume";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(341, 24);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(137, 39);
            this.optionsLabel.TabIndex = 13;
            this.optionsLabel.Text = "Options";
            // 
            // customLabel
            // 
            this.customLabel.AutoSize = true;
            this.customLabel.Location = new System.Drawing.Point(341, 38);
            this.customLabel.Name = "customLabel";
            this.customLabel.Size = new System.Drawing.Size(42, 13);
            this.customLabel.TabIndex = 22;
            this.customLabel.Text = "Custom";
            // 
            // staticPlatformsTextbox
            // 
            this.staticPlatformsTextbox.Location = new System.Drawing.Point(350, 62);
            this.staticPlatformsTextbox.MaxLength = 4;
            this.staticPlatformsTextbox.Name = "staticPlatformsTextbox";
            this.staticPlatformsTextbox.Size = new System.Drawing.Size(100, 20);
            this.staticPlatformsTextbox.TabIndex = 23;
            this.staticPlatformsTextbox.Text = "50";
            this.staticPlatformsTextbox.Visible = false;
            // 
            // movingPlatformsTextbox
            // 
            this.movingPlatformsTextbox.Location = new System.Drawing.Point(350, 85);
            this.movingPlatformsTextbox.MaxLength = 4;
            this.movingPlatformsTextbox.Name = "movingPlatformsTextbox";
            this.movingPlatformsTextbox.Size = new System.Drawing.Size(100, 20);
            this.movingPlatformsTextbox.TabIndex = 24;
            this.movingPlatformsTextbox.Text = "50";
            this.movingPlatformsTextbox.Visible = false;
            // 
            // staticPlatformsLabel
            // 
            this.staticPlatformsLabel.AutoSize = true;
            this.staticPlatformsLabel.Location = new System.Drawing.Point(256, 65);
            this.staticPlatformsLabel.Name = "staticPlatformsLabel";
            this.staticPlatformsLabel.Size = new System.Drawing.Size(80, 13);
            this.staticPlatformsLabel.TabIndex = 25;
            this.staticPlatformsLabel.Text = "Static Platforms";
            this.staticPlatformsLabel.Visible = false;
            // 
            // movingPlatformsLabel
            // 
            this.movingPlatformsLabel.AutoSize = true;
            this.movingPlatformsLabel.Location = new System.Drawing.Point(256, 88);
            this.movingPlatformsLabel.Name = "movingPlatformsLabel";
            this.movingPlatformsLabel.Size = new System.Drawing.Size(88, 13);
            this.movingPlatformsLabel.TabIndex = 26;
            this.movingPlatformsLabel.Text = "Moving Platforms";
            this.movingPlatformsLabel.Visible = false;
            // 
            // playerSpeedLabel
            // 
            this.playerSpeedLabel.AutoSize = true;
            this.playerSpeedLabel.Location = new System.Drawing.Point(256, 111);
            this.playerSpeedLabel.Name = "playerSpeedLabel";
            this.playerSpeedLabel.Size = new System.Drawing.Size(70, 13);
            this.playerSpeedLabel.TabIndex = 28;
            this.playerSpeedLabel.Text = "Player Speed";
            this.playerSpeedLabel.Visible = false;
            // 
            // playerSpeedTextbox
            // 
            this.playerSpeedTextbox.Location = new System.Drawing.Point(350, 108);
            this.playerSpeedTextbox.MaxLength = 4;
            this.playerSpeedTextbox.Name = "playerSpeedTextbox";
            this.playerSpeedTextbox.Size = new System.Drawing.Size(100, 20);
            this.playerSpeedTextbox.TabIndex = 27;
            this.playerSpeedTextbox.Text = "10";
            this.playerSpeedTextbox.Visible = false;
            // 
            // performanceWarningLabel
            // 
            this.performanceWarningLabel.AutoSize = true;
            this.performanceWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.performanceWarningLabel.Location = new System.Drawing.Point(274, 145);
            this.performanceWarningLabel.Name = "performanceWarningLabel";
            this.performanceWarningLabel.Size = new System.Drawing.Size(238, 13);
            this.performanceWarningLabel.TabIndex = 29;
            this.performanceWarningLabel.Text = "Note: High values can result in poor performance";
            this.performanceWarningLabel.Visible = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.difficultySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.gameplayTab.ResumeLayout(false);
            this.gameplayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.soundTab.ResumeLayout(false);
            this.soundTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar difficultySlider;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label impossibleLabel;
        private System.Windows.Forms.Button toggleSoundButton;
        private System.Windows.Forms.Label toggleMusicLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gameplayTab;
        private System.Windows.Forms.TabPage soundTab;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton bomberOption;
        private System.Windows.Forms.RadioButton rangerOption;
        private System.Windows.Forms.RadioButton fighterOption;
        private System.Windows.Forms.RadioButton explorerOption;
        private System.Windows.Forms.Label movingPlatformsLabel;
        private System.Windows.Forms.Label staticPlatformsLabel;
        private System.Windows.Forms.TextBox movingPlatformsTextbox;
        private System.Windows.Forms.TextBox staticPlatformsTextbox;
        private System.Windows.Forms.Label customLabel;
        private System.Windows.Forms.Label playerSpeedLabel;
        private System.Windows.Forms.TextBox playerSpeedTextbox;
        private System.Windows.Forms.Label performanceWarningLabel;
    }
}