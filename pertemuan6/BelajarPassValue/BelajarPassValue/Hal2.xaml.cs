using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BelajarPassValue
{
    /// <summary>
    /// Interaction logic for Hal2.xaml
    /// </summary>
    public partial class Hal2 : Window
    {
        public Hal2(string nama, string ttl, string usia, double tb, double bb, string jk)
        {
            InitializeComponent();
            string tampil_jk = "";
            if (jk.Equals("Laki-laki"))
            {
                tampil_jk = "Laki-Laki";
            }
            else if (jk.Equals("Perempuan"))
            {
                tampil_jk = "Perempuan";
            }


            txtHasil.Text = "Hallo, Saya " + nama + "!\nSaya lahir di " + ttl + "!\nSaya berusia " + usia + "Tahun\n" +
                "Tinggi : " + tb + "cm.\nBerat : " + bb + "kg.\nSaya seorang " + tampil_jk;

            double total = bb / ((tb / 100) * (tb / 100));

            if (total < 18.5)
            {
                txtBMI.Text = "Kalkulasi BMI : " + total + "\nStatus : Berat dibawah batas normal ";
            }
            else if (total > 18.5 && total < 24.9)
            {
                txtBMI.Text = "Kalkulasi BMI : " + total + "\nStatus : Berat Normal ";
            }
            else if (total > 25 && total < 29.9)
            {
                txtBMI.Text = "Kalkulasi BMI : " + total + "\nStatus : Kegemukan ";
            }
            else if (total > 30)
            {
                txtBMI.Text = "Kalkulasi BMI : " + total + "\nStatus : Obesitas ";
            }
        }
    }
}
