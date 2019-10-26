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
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
            PopulateDatagrid();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var dbContext = new Users();
            int id = (int)dtgUsers.SelectedCells[0].Value;
            var UsernameToRemove = dbContext.Useres.First(x => x.Id == id);
            dbContext.Useres.Remove(UsernameToRemove);
            dbContext.SaveChanges();
            PopulateDatagrid();
        }

        private void PopulateDatagrid()
        {
            var dbContext = new Users();
            var binding = new BindingSource { DataSource = dbContext.Useres.ToList() };
            dtgUsers.DataSource = binding;
        }
    }
}
