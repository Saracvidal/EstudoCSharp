namespace LinearSearch
{
    partial class LinearSearch
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "LinearSearch";

            this.searchButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();

            //Search Button
            this.searchButton.Location = new System.Drawing.Point(29, 138);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 27);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search Entry";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            //inputTextBox
            this.inputTextBox.Location = new System.Drawing.Point(211, 18);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(120, 22);
            this.inputTextBox.TabIndex = 1;

            //outputLabel
            this.outputLabel.Location = new System.Drawing.Point(10, 18);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(163, 27);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Search Label:";


        }

        #endregion
    }
}

