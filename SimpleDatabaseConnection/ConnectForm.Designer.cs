namespace SimpleDatabaseConnection
{
    partial class ConnectForm
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
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.serverIPLabel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DB_textBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(118, 43);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(134, 20);
            this.IP_textBox.TabIndex = 7;
            this.IP_textBox.Text = "127.0.0.1";
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.serverIPLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverIPLabel.Location = new System.Drawing.Point(12, 46);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(100, 13);
            this.serverIPLabel.TabIndex = 8;
            this.serverIPLabel.Text = "IP Adress";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Port Number";
            // 
            // Port_textBox
            // 
            this.Port_textBox.Location = new System.Drawing.Point(118, 69);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(134, 20);
            this.Port_textBox.TabIndex = 9;
            this.Port_textBox.Text = "3306";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Databse Name";
            // 
            // DB_textBox
            // 
            this.DB_textBox.Location = new System.Drawing.Point(118, 95);
            this.DB_textBox.Name = "DB_textBox";
            this.DB_textBox.Size = new System.Drawing.Size(134, 20);
            this.DB_textBox.TabIndex = 11;
            this.DB_textBox.Text = "testcase";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(12, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "User Name";
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(118, 121);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(134, 20);
            this.Username_textBox.TabIndex = 13;
            this.Username_textBox.Text = "TestCase";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(12, 150);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 13);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "Password";
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(118, 147);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(134, 20);
            this.Pass_textBox.TabIndex = 15;
            this.Pass_textBox.Text = "StrongPassword12345";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 183);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(240, 41);
            this.connectButton.TabIndex = 17;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 16);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Connect to MySql Server";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 231);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DB_textBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Port_textBox);
            this.Controls.Add(this.serverIPLabel);
            this.Controls.Add(this.IP_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.TextBox serverIPLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox DB_textBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

