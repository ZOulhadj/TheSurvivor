namespace TheSurvivor
{
    partial class GameForm
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
            this.gameBackground = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.upTimer = new System.Windows.Forms.Timer(this.components);
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimer = new System.Windows.Forms.Timer(this.components);
            this.wall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBackground
            // 
            this.gameBackground.Image = global::TheSurvivor.Properties.Resources.Background2;
            this.gameBackground.Location = new System.Drawing.Point(-3, -7);
            this.gameBackground.Name = "gameBackground";
            this.gameBackground.Size = new System.Drawing.Size(630, 565);
            this.gameBackground.TabIndex = 0;
            this.gameBackground.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(34, 362);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Interval = 10;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ground.Location = new System.Drawing.Point(-3, 418);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(630, 140);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // upTimer
            // 
            this.upTimer.Interval = 10;
            this.upTimer.Tick += new System.EventHandler(this.upTimer_Tick);
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 10;
            this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
            // 
            // leftTimer
            // 
            this.leftTimer.Interval = 10;
            this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.RoyalBlue;
            this.wall.Location = new System.Drawing.Point(342, 281);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(100, 50);
            this.wall.TabIndex = 3;
            this.wall.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 549);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.player);
            this.Controls.Add(this.gameBackground);
            this.Name = "GameForm";
            this.Text = "The Survior";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBackground;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer upTimer;
        private System.Windows.Forms.Timer rightTimer;
        private System.Windows.Forms.Timer leftTimer;
        private System.Windows.Forms.PictureBox wall;
    }
}

