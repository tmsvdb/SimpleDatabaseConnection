namespace SimpleDatabaseConnection
{
    partial class InputPopup
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.okeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.Menu;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(12, 12);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(260, 13);
            this.messageBox.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 38);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(260, 20);
            this.inputBox.TabIndex = 1;
            // 
            // okeButton
            // 
            this.okeButton.Location = new System.Drawing.Point(102, 66);
            this.okeButton.Name = "okeButton";
            this.okeButton.Size = new System.Drawing.Size(75, 23);
            this.okeButton.TabIndex = 2;
            this.okeButton.Text = "oke";
            this.okeButton.UseVisualStyleBackColor = true;
            this.okeButton.Click += new System.EventHandler(this.okeButton_Click);
            // 
            // InputPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.okeButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.messageBox);
            this.Name = "InputPopup";
            this.Text = "Input Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button okeButton;
    }
}