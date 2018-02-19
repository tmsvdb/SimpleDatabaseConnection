namespace SimpleDatabaseConnection
{
    partial class ContentBrowseForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTableButton = new System.Windows.Forms.Button();
            this.bdNameText = new System.Windows.Forms.TextBox();
            this.createDBButton = new System.Windows.Forms.Button();
            this.removeDBButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.insertButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableNameBox = new System.Windows.Forms.TextBox();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(224, 379);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(242, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 379);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addTableButton);
            this.tabPage1.Controls.Add(this.bdNameText);
            this.tabPage1.Controls.Add(this.createDBButton);
            this.tabPage1.Controls.Add(this.removeDBButton);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTableButton.Location = new System.Drawing.Point(17, 176);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(286, 23);
            this.addTableButton.TabIndex = 5;
            this.addTableButton.Text = "Add New Table";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // bdNameText
            // 
            this.bdNameText.BackColor = System.Drawing.SystemColors.Menu;
            this.bdNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdNameText.Location = new System.Drawing.Point(17, 20);
            this.bdNameText.Multiline = true;
            this.bdNameText.Name = "bdNameText";
            this.bdNameText.Size = new System.Drawing.Size(286, 92);
            this.bdNameText.TabIndex = 4;
            // 
            // createDBButton
            // 
            this.createDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDBButton.Location = new System.Drawing.Point(17, 147);
            this.createDBButton.Name = "createDBButton";
            this.createDBButton.Size = new System.Drawing.Size(286, 23);
            this.createDBButton.TabIndex = 3;
            this.createDBButton.Text = "Create New Database";
            this.createDBButton.UseVisualStyleBackColor = true;
            this.createDBButton.Click += new System.EventHandler(this.createDBButton_Click);
            // 
            // removeDBButton
            // 
            this.removeDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDBButton.Location = new System.Drawing.Point(17, 118);
            this.removeDBButton.Name = "removeDBButton";
            this.removeDBButton.Size = new System.Drawing.Size(286, 23);
            this.removeDBButton.TabIndex = 2;
            this.removeDBButton.Text = "Delete";
            this.removeDBButton.UseVisualStyleBackColor = true;
            this.removeDBButton.Click += new System.EventHandler(this.removeDBButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteRowButton);
            this.tabPage2.Controls.Add(this.insertButton);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.tableNameBox);
            this.tabPage2.Controls.Add(this.removeTableButton);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(17, 256);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(286, 23);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert Row";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.UseWaitCursor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 199);
            this.listBox1.TabIndex = 6;
            this.listBox1.UseWaitCursor = true;
            // 
            // tableNameBox
            // 
            this.tableNameBox.BackColor = System.Drawing.SystemColors.Menu;
            this.tableNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableNameBox.Location = new System.Drawing.Point(17, 20);
            this.tableNameBox.Name = "tableNameBox";
            this.tableNameBox.Size = new System.Drawing.Size(286, 19);
            this.tableNameBox.TabIndex = 5;
            this.tableNameBox.UseWaitCursor = true;
            // 
            // removeTableButton
            // 
            this.removeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTableButton.Location = new System.Drawing.Point(17, 314);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(286, 23);
            this.removeTableButton.TabIndex = 3;
            this.removeTableButton.Text = "Delete";
            this.removeTableButton.UseVisualStyleBackColor = true;
            this.removeTableButton.UseWaitCursor = true;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRowButton.Location = new System.Drawing.Point(17, 285);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(286, 23);
            this.deleteRowButton.TabIndex = 8;
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.UseWaitCursor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // ContentBrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 403);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Name = "ContentBrowseForm";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button removeDBButton;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button createDBButton;
        private System.Windows.Forms.TextBox bdNameText;
        private System.Windows.Forms.TextBox tableNameBox;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteRowButton;
    }
}