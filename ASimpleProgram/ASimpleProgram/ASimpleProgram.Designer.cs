namespace ASimpleProgram
{
    partial class ASimpleProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASimpleProgram));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.birdPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(268, 17);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(116, 46);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welome to C#!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // birdPictureBox
            // 
            this.birdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("birdPictureBox.Image")));
            this.birdPictureBox.Location = new System.Drawing.Point(270, 112);
            this.birdPictureBox.Name = "birdPictureBox";
            this.birdPictureBox.Size = new System.Drawing.Size(260, 257);
            this.birdPictureBox.TabIndex = 1;
            this.birdPictureBox.TabStop = false;
            // 
            // ASimpleProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birdPictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "ASimpleProgram";
            this.Text = "A Simple Program";
            this.Load += new System.EventHandler(this.ASimpleProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox birdPictureBox;
    }
}

