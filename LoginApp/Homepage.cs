using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public Homepage(string Username)
        {
            InitializeComponent();
            lblUsername.Text = "Welcome to our Desktop app " + Username;
        }
    }
}
