using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistic_Calculator
{
    public partial class FormPilihan : Form
    {
        public FormPilihan()
        {
            InitializeComponent();
        }

        private void buttonNoData_Click(object sender, EventArgs e)
        {
            FormData form = new FormData();
            form.Show();
        }
    }
}
