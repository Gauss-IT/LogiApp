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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            var form = new ShowData();
            form.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var form = new RegisterUsers();
            form.Show();

        }
    }
}
