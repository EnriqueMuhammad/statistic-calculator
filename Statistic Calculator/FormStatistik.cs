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
    public partial class FormStatistik : Form
    {
        Statistics statistics = Statistics.Instance;
        public FormStatistik()
        {
            InitializeComponent();
        }

        private void FormStatistik_Load(object sender, EventArgs e)
        {
            double bawah = statistics.BatasBawah;
            double atas = 0;
            for (int i = 0; i < statistics.JumlahKelompok; i++)
            {
                atas = bawah + statistics.LebarKelompok;
                dataGridViewStat.Rows.Add(
                    string.Format("{0:0.00}", bawah), 
                    string.Format("{0:0.00}", atas), 
                    0, 
                    0,
                    0,
                    string.Format("{0:0.00}",Middle(bawah, atas)),
                    0);
                bawah += statistics.LebarKelompok;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewStat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            CumulativeFreq(e, row);
            RelativeFreq(row);

            if(e.RowIndex == statistics.JumlahKelompok - 1)
            {
                dataGridViewStat.Rows.Add(
                  0,
                  0,
                  statistics.JumlahData,
                  0,
                  1,
                  0,
                  0);

            }
           
        }

        private void RelativeFreq(int row)
        {
            double currentFreq = Convert.ToDouble(dataGridViewStat.Rows[row].Cells[2].Value);
            dataGridViewStat.Rows[row].Cells[4].Value = string.Format("{0:0.00}", currentFreq / statistics.JumlahData);
        }

        private void CumulativeFreq(DataGridViewCellEventArgs e, int row)
        {
            if (e.RowIndex == 0)
            {
                dataGridViewStat.Rows[row].Cells[3].Value = dataGridViewStat.Rows[row].Cells[2].Value;
            }
            else
            {
                double frekkum = Convert.ToDouble(dataGridViewStat.Rows[row - 1].Cells[3].Value);
                double currFrek = Convert.ToDouble(dataGridViewStat.Rows[row].Cells[2].Value);
                dataGridViewStat.Rows[row].Cells[3].Value = frekkum + currFrek;
            }
        }

        private double Middle(double bawah, double atas)
        {
            double middle = (atas + bawah) / 2;
            return middle;
        }
    }
}
