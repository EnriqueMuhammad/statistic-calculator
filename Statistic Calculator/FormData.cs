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
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxRendah.Text != null && textBoxTinggi.Text != null && textBoxJumlahData.Text != null && textBoxTeliti.Text != null)
            {
                try
                {
                    Statistics statistics = Statistics.Instance;

                    double tinggi = double.Parse(textBoxTinggi.Text);
                    double rendah = double.Parse(textBoxRendah.Text);
                    double ketelitian = double.Parse(textBoxTeliti.Text);
                    int jumlahData = int.Parse(textBoxJumlahData.Text);

                    statistics.JumlahData = jumlahData;
                    statistics.Range = statistics.HitungRange(tinggi, rendah, ketelitian);

                    statistics.JumlahKelompok = statistics.HitungKelompok(statistics.JumlahData);
                    statistics.LebarKelompok = statistics.HitungLebar(statistics.Range, statistics.JumlahKelompok);

                    statistics.Sisa = statistics.HitungSisa(statistics.LebarKelompok, statistics.JumlahKelompok, statistics.Range);
                    statistics.BatasBawah = rendah - statistics.Sisa;


                    FormStatistik form = new FormStatistik();
                    form.Show();
                }
                catch(Exception error)
                {
                    MessageBox.Show($"Gagal, Error : {error.Message}", "Warning");
                }
            }
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            
        }

        private void Debug()
        {
            textBoxRendah.Text = "21";
            textBoxTinggi.Text = "79";
            textBoxJumlahData.Text = "50";
            textBoxTeliti.Text = "1";
        }
    }
}
