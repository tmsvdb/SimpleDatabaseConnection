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
    public partial class InsertDataPopup : Form
    {
        private Action<string, string, string> onClosed;

        public InsertDataPopup(string msg, Action<string, string, string> onClosed)
        {
            this.onClosed = onClosed;
            InitializeComponent();
        }

        private void okeButton_Click_1(object sender, EventArgs e)
        {
            onClosed.Invoke(firstnameBox.Text, lastnameBox.Text, emailBox.Text);
            this.Close();
        }
    }
}
