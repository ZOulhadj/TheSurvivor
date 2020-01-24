namespace TheSurvivor
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.leftMovement = new System.Windows.Forms.Timer(this.components);
            this.rightMovement = new System.Windows.Forms.Timer(this.components);
            this.upMovement = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerObject = new System.Windows.Forms.Panel();
            this.ground = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.gameBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pausePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // leftMovement
            // 
            this.leftMovement.Interval = 10;
            this.leftMovement.Tick += new System.EventHandler(this.leftMovement_Tick);
            // 
            // rightMovement
            // 
            this.rightMovement.Interval = 10;
            this.rightMovement.Tick += new System.EventHandler(this.rightMovement_Tick);
            // 
            // upMovement
            // 
            this.upMovement.Interval = 10;
            this.upMovement.Tick += new System.EventHandler(this.upMovement_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.pictureBox2.Location = new System.Drawing.Point(711, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.SystemColors.Info;
            this.pausePanel.BackgroundImage = global::TheSurvivor.Properties.Resources.Background;
            this.pausePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausePanel.Controls.Add(this.btnContinue);
            this.pausePanel.Controls.Add(this.btnOptions);
            this.pausePanel.Controls.Add(this.btnExit);
            this.pausePanel.Location = new System.Drawing.Point(270, 12);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(373, 537);
            this.pausePanel.TabIndex = 5;
            this.pausePanel.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(50, 26);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(277, 95);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(48, 221);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(277, 95);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(50, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 95);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::TheSurvivor.Properties.Resources.Platform;
            this.pictureBox3.Location = new System.Drawing.Point(646, 141);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::TheSurvivor.Properties.Resources.Platform;
            this.pictureBox1.Location = new System.Drawing.Point(149, 196);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // playerObject
            // 
            this.playerObject.BackgroundImage = global::TheSurvivor.Properties.Resources.Player;
            this.playerObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerObject.Location = new System.Drawing.Point(111, 312);
            this.playerObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerObject.Name = "playerObject";
            this.playerObject.Size = new System.Drawing.Size(156, 148);
            this.playerObject.TabIndex = 4;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ground.Location = new System.Drawing.Point(-11, 535);
            this.ground.Margin = new System.Windows.Forms.Padding(0);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(919, 32);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.platform.Image = global::TheSurvivor.Properties.Resources.Platform;
            this.platform.Location = new System.Drawing.Point(460, 335);
            this.platform.Margin = new System.Windows.Forms.Padding(0);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(188, 40);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.platform.TabIndex = 3;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // gameBackground
            // 
            this.gameBackground.Image = global::TheSurvivor.Properties.Resources.Background2;
            this.gameBackground.Location = new System.Drawing.Point(-92, -3);
            this.gameBackground.Name = "gameBackground";
            this.gameBackground.Size = new System.Drawing.Size(988, 598);
            this.gameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameBackground.TabIndex = 0;
            this.gameBackground.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.pictureBox4.Location = new System.Drawing.Point(753, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.pictureBox5.Location = new System.Drawing.Point(795, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.pictureBox6.Location = new System.Drawing.Point(837, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerObject);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.gameBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Survior";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pausePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBackground;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel playerObject;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer leftMovement;
        private System.Windows.Forms.Timer rightMovement;
        private System.Windows.Forms.Timer upMovement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

