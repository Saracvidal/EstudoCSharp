namespace DoubleArray
{
    partial class DoubleArray
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
            this.showOutputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showOutputButton
            // 
            this.showOutputButton.Location = new System.Drawing.Point(235, 12);
            this.showOutputButton.Name = "showOutputButton";
            this.showOutputButton.Size = new System.Drawing.Size(134, 27);
            this.showOutputButton.TabIndex = 5;
            this.showOutputButton.Text = "Show Output";
            this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(23, 86);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(568, 268);
            this.outputLabel.TabIndex = 0;
            // 
            // DoubleArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 379);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.showOutputButton);
            this.Name = "DoubleArray";
            this.Text = "DoubleArray";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

