using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak;
using Zadatak.Dal;
using Zadatak.Models;

namespace Zadatak0102
{
    public partial class DMLqueryForm : Form
    {
        public DMLqueryForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            dgvQueryView.DataSource = RepositoryFactory.GetRepository().GetQuery(tbDML.Text);
            
        }
    }
}
