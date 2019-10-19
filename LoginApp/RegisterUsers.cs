using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace LoginApp
{
    public partial class RegisterUsers : Form
    {
        public RegisterUsers()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var dbContext = new Users();
            var newUser = new User();
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Username field or password field are empty!");
            else
            {
                newUser.UserName = txtUsername.Text;
                newUser.Password = txtPassword.Text;
                dbContext.Useres.Add(newUser);
                dbContext.SaveChanges();
                MessageBox.Show("Username added");
            }
        }
    }
}
