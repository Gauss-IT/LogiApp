using System.Linq;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            var dbContext = new Users();
            var binding = new BindingSource { DataSource = dbContext.Useres.ToList() };
            dtgUsers.DataSource = binding;
        }


    }
}
