using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDatabaseConnection
{
    public partial class ContentBrowseForm : Form
    {
        MySqlManager mySqlManager;
        public TreeNode nodeSelected;
        public int selectedContentRow;

        public ContentBrowseForm (MySqlManager mySqlManager) : base ()
        {
            InitializeComponent();
            this.mySqlManager = mySqlManager;

            UpdateListView();
        }

        private void UpdateListView ()
        {
            treeView1.Nodes.Clear();

            List<List<string>> dblist = mySqlManager.SqlCommand(MySqlCommands.ListAllDatabases());

            if (dblist != null)
            {
                treeView1.BeginUpdate();
                for (int i = 0; i < dblist.Count; i++)
                {
                    treeView1.Nodes.Add(dblist[i][0]);

                    List<List<string>> tablelist = mySqlManager.SqlCommand(MySqlCommands.ListAllTables(dblist[i][0]));

                    if (tablelist != null)
                    {
                        foreach (List<string> table in tablelist)
                            treeView1.Nodes[i].Nodes.Add(table[0]);
                    }
                    else ShowMessage(mySqlManager.ResponseMessage);
                }
                treeView1.EndUpdate();
            }
            else ShowMessage(mySqlManager.ResponseMessage);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("treeview selection ("+ e.Node.Level + ","+ e.Node.Index +")" + e.Node.Text);

            nodeSelected = e.Node;

            if (e.Node.Level == 0)
            {
                tabControl1.SelectTab(0);
                bdNameText.Text = "Database name: " + e.Node.Text;
            }
            else if (e.Node.Level == 1)
            {
                tabControl1.SelectTab(1);
                tableNameBox.Text = "Table name: " + e.Node.Text;

                UpdateContentBox();
            }
        }

        private void UpdateContentBox ()
        {
            List<List<string>> list = mySqlManager.SqlCommand(MySqlCommands.ListAllTableContent(nodeSelected.Parent.Text + "." + nodeSelected.Text));
            if (list == null) ShowMessage(mySqlManager.ResponseMessage);
            else
            {
                listBox1.Items.Clear();

                foreach (List<string> item in list)
                {
                    if (item.Count == 5)
                    {
                        listBox1.Items.Add(new DataType(item[1], item[2], item[3]));
                    }
                    else
                    {
                        string str = "";
                        foreach (string field in item)
                            str += string.Format("[{0}] ", field);
                        listBox1.Items.Add(str);
                    }
                }
            }
        }

        private void removeDBButton_Click(object sender, EventArgs e)
        {
            List<List<string>> tablelist = mySqlManager.SqlCommand(MySqlCommands.RemoveDatabase(nodeSelected.Text));
            if (tablelist == null) ShowMessage(mySqlManager.ResponseMessage);
            UpdateListView();
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            List<List<string>> tablelist = mySqlManager.SqlCommand(MySqlCommands.RemoveTable(nodeSelected.Text));
            if (tablelist == null) ShowMessage(mySqlManager.ResponseMessage);
            UpdateListView();
        }

        private void ShowMessage (string msg)
        {
            MessageBox.Show(mySqlManager.ResponseMessage);
        }

        private void createDBButton_Click(object sender, EventArgs e)
        {
            InputPopup popup = new InputPopup("Enter Database Name", (string input) => {
                List<List<string>> list = mySqlManager.SqlCommand(MySqlCommands.CreateNewDatabase(input));
                if (list == null) ShowMessage(mySqlManager.ResponseMessage);
                UpdateListView();
            });
            popup.Show();
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            InputPopup popup = new InputPopup("Enter Table Name", (string input) => {
                List<List<string>> list = mySqlManager.SqlCommand(MySqlCommands.CreateNewTable(nodeSelected.Text, input));
                if (list == null) ShowMessage(mySqlManager.ResponseMessage);
                UpdateListView();
            });
            popup.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertDataPopup popup = new InsertDataPopup("Enter Table Name", (string fname, string lname, string email) => {
                DataType data = new DataType(fname, lname, email);
                List<List<string>> list = mySqlManager.SqlCommand(MySqlCommands.InsertTableContent(nodeSelected.Parent.Text + "." + nodeSelected.Text, data));
                if (list == null) ShowMessage(mySqlManager.ResponseMessage);
                UpdateContentBox();
            });
            popup.Show();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex
            //List<List<string>> list = mySqlManager.SqlCommand(MySqlCommands.R);
            //if (list == null) ShowMessage(mySqlManager.ResponseMessage);
            //UpdateContentBox();
        }
    }
}
