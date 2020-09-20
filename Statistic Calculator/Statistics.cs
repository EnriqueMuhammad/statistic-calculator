using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic_Calculator
{
    public class Statistics
    {
        double range;
        int jumlahKelompok;
        int jumlahData;
        double lebarKelompok;
        double sisa;
        double batasBawah;

        private static Statistics instance;

        private Statistics()
        {
            Range = 0;
            BatasBawah = 0;
            JumlahKelompok = 0;
            JumlahData = 0;
            LebarKelompok = 0;
            Sisa = 0;
        }

        public static Statistics Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Statistics();
                }
                return instance;
            }
        }

        public double Range { get => range; set => range = value; }
        public int JumlahKelompok { get => jumlahKelompok; set => jumlahKelompok = value; }
        public int JumlahData { get => jumlahData; set => jumlahData = value; }
        public double LebarKelompok { get => lebarKelompok; set => lebarKelompok = value; }
        public double Sisa { get => sisa; set => sisa = value; }
        public double BatasBawah { get => batasBawah; set => batasBawah = value; }

        public double HitungRange(double tinggi, double rendah, double ketelitian)
        {
            double range = tinggi - rendah + ketelitian;
            return range;
        }

        public int HitungKelompok(int jumlahData)
        {
            int kelompok = Convert.ToInt32(1 + (3.3 * Math.Log10(jumlahData)));
            double kel = Math.Log10(50);
            return kelompok;
        }

        public double HitungLebar(double range, int kelompok)
        {
            double lebar = range / kelompok;
            return lebar;
        }

        public double HitungSisa(double lebar, int kelompok, double range)
        {
            double sisa = ((lebar * kelompok) - range) / 2;
            return sisa;
        }
        

    }
}
