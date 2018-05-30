namespace TwoDimensionalArrays
{
    partial class TwoDimensionalArrays
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.outputLabel = new System.Windows.Forms.Label();
            this.showOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(26, 89);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(577, 187);
            this.outputLabel.TabIndex = 0;
            // 
            // showOutputButton
            // 
            this.showOutputButton.Location = new System.Drawing.Point(245, 12);
            this.showOutputButton.Name = "showOutputButton";
            this.showOutputButton.Size = new System.Drawing.Size(134, 27);
            this.showOutputButton.TabIndex = 5;
            this.showOutputButton.Text = "Show Output";
            this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
            // 
            // TwoDimensionalArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 297);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.showOutputButton);
            this.Name = "TwoDimensionalArrays";
            this.Text = "TwoDimensionalArrays";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

