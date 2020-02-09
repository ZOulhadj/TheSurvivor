namespace TheSurvivor.Forms
{
    partial class DeathScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Died!";
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.Location = new System.Drawing.Point(379, 183);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(75, 23);
            this.tryAgainBtn.TabIndex = 1;
            this.tryAgainBtn.Text = "Try Again";
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(379, 241);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.AutoSize = true;
            this.finalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.Location = new System.Drawing.Point(278, 146);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(133, 25);
            this.finalScoreLabel.TabIndex = 3;
            this.finalScoreLabel.Text = "Final Score: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheSurvivor.Properties.Resources.DeathTroll;
            this.pictureBox2.Location = new System.Drawing.Point(750, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(379, 212);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Main Menu";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.label1);
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            this.Load += new System.EventHandler(this.DeathScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tryAgainBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button homeButton;
    }
}