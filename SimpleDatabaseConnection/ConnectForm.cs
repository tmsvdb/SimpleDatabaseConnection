using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SimpleDatabaseConnection
{
    public partial class ConnectForm : Form
    {
        MySqlManager mySqlManager;
        ContentBrowseForm contentForm;

        public ConnectForm()
        {
            InitializeComponent();
            mySqlManager = new MySqlManager();
            this.Text = "SimpleDatabaseConnection";
        }

        /*
         * Form elements event handlers
        */

        private void connectButton_Click(object sender, EventArgs e)
        {
            mySqlManager.ConnectToServer(IP_textBox.Text, Port_textBox.Text, DB_textBox.Text, Username_textBox.Text, Pass_textBox.Text);

            if (mySqlManager.IsConnected)
            {
                if (contentForm != null)
                    contentForm.Close();

                contentForm = new ContentBrowseForm(mySqlManager);
                contentForm.Show();
                contentForm.Text = string.Format("Connected To {0}:{1}-{2}", IP_textBox.Text, Port_textBox.Text, DB_textBox.Text);
            }
            else
            {
                MessageBox.Show(mySqlManager.ResponseMessage);
            }
        }
    }
}
