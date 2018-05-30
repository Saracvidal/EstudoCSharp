namespace BinarySearchTest
{
    partial class BinarySeachTest
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.findButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.Location = new System.Drawing.Point(50, 18);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(77, 27);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Entry Key:";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(50, 58);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(163, 27);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Result:";
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(50, 88);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(163, 27);
            this.displayLabel.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(50, 118);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(526, 170);
            this.outputLabel.TabIndex = 3;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(133, 18);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(136, 22);
            this.inputTextBox.TabIndex = 4;
            // 
            // findButon
            // 
            this.findButon.Location = new System.Drawing.Point(303, 18);
            this.findButon.Name = "findButon";
            this.findButon.Size = new System.Drawing.Size(134, 27);
            this.findButon.TabIndex = 5;
            this.findButon.Text = "Find";
            this.findButon.Click += new System.EventHandler(this.findButton_Click);
            // 
            // BinarySeachTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 297);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.findButon);
            this.Name = "BinarySeachTest";
            this.Text = "BinarySearchTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

