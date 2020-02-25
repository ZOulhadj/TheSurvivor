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
            this.toggleMusicButton = new System.Windows.Forms.Button();
            this.toggleMusicLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gameplayTab = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.musicTab = new System.Windows.Forms.TabPage();
            this.musicLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.bomberOption = new System.Windows.Forms.RadioButton();
            this.explorerOption = new System.Windows.Forms.RadioButton();
            this.fighterOption = new System.Windows.Forms.RadioButton();
            this.rangerOption = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.difficultySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.gameplayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.musicTab.SuspendLayout();
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
            this.difficultySlider.Location = new System.Drawing.Point(98, 6);
            this.difficultySlider.Maximum = 4;
            this.difficultySlider.Minimum = 1;
            this.difficultySlider.Name = "difficultySlider";
            this.difficultySlider.Size = new System.Drawing.Size(181, 45);
            this.difficultySlider.TabIndex = 3;
            this.difficultySlider.Value = 1;
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
            this.mediumLabel.Location = new System.Drawing.Point(141, 38);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(44, 13);
            this.mediumLabel.TabIndex = 5;
            this.mediumLabel.Text = "Medium";
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.Location = new System.Drawing.Point(200, 38);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(30, 13);
            this.hardLabel.TabIndex = 6;
            this.hardLabel.Text = "Hard";
            // 
            // impossibleLabel
            // 
            this.impossibleLabel.AutoSize = true;
            this.impossibleLabel.Location = new System.Drawing.Point(243, 38);
            this.impossibleLabel.Name = "impossibleLabel";
            this.impossibleLabel.Size = new System.Drawing.Size(56, 13);
            this.impossibleLabel.TabIndex = 7;
            this.impossibleLabel.Text = "Impossible";
            // 
            // toggleMusicButton
            // 
            this.toggleMusicButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleMusicButton.Location = new System.Drawing.Point(6, 14);
            this.toggleMusicButton.Name = "toggleMusicButton";
            this.toggleMusicButton.Size = new System.Drawing.Size(132, 27);
            this.toggleMusicButton.TabIndex = 8;
            this.toggleMusicButton.Text = "Toggle Music";
            this.toggleMusicButton.UseVisualStyleBackColor = true;
            this.toggleMusicButton.Click += new System.EventHandler(this.toggleMusicButton_Click);
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
            this.tabControl1.Controls.Add(this.musicTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 343);
            this.tabControl1.TabIndex = 12;
            // 
            // gameplayTab
            // 
            this.gameplayTab.BackColor = System.Drawing.SystemColors.Control;
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
            // musicTab
            // 
            this.musicTab.BackColor = System.Drawing.SystemColors.Control;
            this.musicTab.Controls.Add(this.musicLabel);
            this.musicTab.Controls.Add(this.trackBar1);
            this.musicTab.Controls.Add(this.toggleMusicButton);
            this.musicTab.Controls.Add(this.toggleMusicLabel);
            this.musicTab.Location = new System.Drawing.Point(4, 22);
            this.musicTab.Name = "musicTab";
            this.musicTab.Padding = new System.Windows.Forms.Padding(3);
            this.musicTab.Size = new System.Drawing.Size(768, 317);
            this.musicTab.TabIndex = 1;
            this.musicTab.Text = "Music";
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLabel.Location = new System.Drawing.Point(6, 48);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(118, 19);
            this.musicLabel.TabIndex = 12;
            this.musicLabel.Text = "Music Volume";
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
            // bomberOption
            // 
            this.bomberOption.AutoSize = true;
            this.bomberOption.Checked = true;
            this.bomberOption.Location = new System.Drawing.Point(641, 17);
            this.bomberOption.Name = "bomberOption";
            this.bomberOption.Size = new System.Drawing.Size(61, 17);
            this.bomberOption.TabIndex = 18;
            this.bomberOption.Text = "Bomber";
            this.bomberOption.UseVisualStyleBackColor = true;
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
            this.musicTab.ResumeLayout(false);
            this.musicTab.PerformLayout();
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
        private System.Windows.Forms.Button toggleMusicButton;
        private System.Windows.Forms.Label toggleMusicLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gameplayTab;
        private System.Windows.Forms.TabPage musicTab;
        private System.Windows.Forms.Label musicLabel;
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
    }
}