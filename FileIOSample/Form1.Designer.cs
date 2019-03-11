namespace FileIOSample
{
    partial class Form1
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
            this.saveDataButton = new System.Windows.Forms.Button();
            this.readDataButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(36, 172);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(148, 97);
            this.saveDataButton.TabIndex = 0;
            this.saveDataButton.Text = "Save data to Text File";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(355, 172);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(161, 97);
            this.readDataButton.TabIndex = 1;
            this.readDataButton.Text = "Read data to Text File";
            this.readDataButton.UseVisualStyleBackColor = true;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(36, 23);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(480, 106);
            this.dataTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 307);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.saveDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}

