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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var dbContext = new Users();
            if (dbContext.Useres.Any(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text))
            {
                MessageBox.Show("Username and password correct!");
                string username = txtUsername.Text;
                this.Hide();
                var form = new Homepage(username);
                form.Show();
            }
            else
                MessageBox.Show("Username and password incorrect!");
        }
    }
}
