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
            this.pausePanel = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.xAxisMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerControl = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.PictureBox();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.playerFuel = new System.Windows.Forms.ProgressBar();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.pausePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pausePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pausePanel.Controls.Add(this.btnContinue);
            this.pausePanel.Controls.Add(this.btnOptions);
            this.pausePanel.Controls.Add(this.btnExit);
            this.pausePanel.Location = new System.Drawing.Point(727, 148);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(162, 193);
            this.pausePanel.TabIndex = 5;
            this.pausePanel.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(50, 26);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(70, 44);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(50, 76);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(70, 47);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(50, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // xAxisMovementTimer
            // 
            this.xAxisMovementTimer.Enabled = true;
            this.xAxisMovementTimer.Interval = 1;
            this.xAxisMovementTimer.Tick += new System.EventHandler(this.xAxisMovementTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(12, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(151, 38);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score: 0";
            // 
            // playerControl
            // 
            this.playerControl.BackColor = System.Drawing.Color.Black;
            this.playerControl.BackgroundImage = global::TheSurvivor.Properties.Resources.Bomber;
            this.playerControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerControl.Location = new System.Drawing.Point(439, 343);
            this.playerControl.Margin = new System.Windows.Forms.Padding(0);
            this.playerControl.Name = "playerControl";
            this.playerControl.Size = new System.Drawing.Size(53, 54);
            this.playerControl.TabIndex = 4;
            // 
            // background
            // 
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Image = global::TheSurvivor.Properties.Resources.Background;
            this.background.Location = new System.Drawing.Point(-4, -6);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(919, 762);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 6;
            this.background.TabStop = false;
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.BackColor = System.Drawing.Color.Black;
            this.fuelLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.ForeColor = System.Drawing.Color.White;
            this.fuelLabel.Location = new System.Drawing.Point(277, 12);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(103, 38);
            this.fuelLabel.TabIndex = 8;
            this.fuelLabel.Text = "Fuel:";
            // 
            // playerFuel
            // 
            this.playerFuel.Location = new System.Drawing.Point(392, 19);
            this.playerFuel.Maximum = 1000;
            this.playerFuel.Name = "playerFuel";
            this.playerFuel.Size = new System.Drawing.Size(100, 24);
            this.playerFuel.TabIndex = 9;
            this.playerFuel.Value = 1000;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Black;
            this.heart3.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.heart3.Location = new System.Drawing.Point(859, 12);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(43, 38);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart3.TabIndex = 10;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Black;
            this.heart2.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.heart2.Location = new System.Drawing.Point(810, 12);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(43, 38);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart2.TabIndex = 11;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Black;
            this.heart1.Image = global::TheSurvivor.Properties.Resources.Heart;
            this.heart1.Location = new System.Drawing.Point(761, 12);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(43, 38);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart1.TabIndex = 12;
            this.heart1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 751);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.playerFuel);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.playerControl);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Survior";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.pausePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel playerControl;
        private System.Windows.Forms.Timer xAxisMovementTimer;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.ProgressBar playerFuel;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart1;
    }
}

