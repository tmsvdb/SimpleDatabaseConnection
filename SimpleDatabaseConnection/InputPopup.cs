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
    public partial class InputPopup : Form
    {
        private Action<string> onClosed;

        public InputPopup(string msg, Action<string> onClosed)
        {
            this.onClosed = onClosed;
            InitializeComponent();
        }

        private void okeButton_Click(object sender, EventArgs e)
        {
            onClosed.Invoke(inputBox.Text);
            this.Close();
        }


    }
}
