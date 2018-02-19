namespace SimpleDatabaseConnection
{
    partial class InsertDataPopup
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.okeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Firstname";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Lastname";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 13);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Email";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(92, 12);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(223, 20);
            this.firstnameBox.TabIndex = 3;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(92, 38);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(223, 20);
            this.lastnameBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(92, 64);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(223, 20);
            this.emailBox.TabIndex = 5;
            // 
            // okeButton
            // 
            this.okeButton.Location = new System.Drawing.Point(12, 90);
            this.okeButton.Name = "okeButton";
            this.okeButton.Size = new System.Drawing.Size(303, 23);
            this.okeButton.TabIndex = 6;
            this.okeButton.Text = "Insert";
            this.okeButton.UseVisualStyleBackColor = true;
            this.okeButton.Click += new System.EventHandler(this.okeButton_Click_1);
            // 
            // InsertDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 121);
            this.Controls.Add(this.okeButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "InsertDataPopup";
            this.Text = "InsertDataPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button okeButton;
    }
}