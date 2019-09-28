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
            var dbContext = new Users();
            var binding = new BindingSource { DataSource = dbContext.Useres.ToList() };
            dtgUsers.DataSource = binding;
        }
    }
}
