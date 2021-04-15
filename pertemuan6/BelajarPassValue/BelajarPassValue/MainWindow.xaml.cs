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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BelajarPassValue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnKlik_Click(object sender, RoutedEventArgs e)
        {
            string nama = txtNama.Text;
            string ttl = txtTtl.Text;
            string usia = txtUsia.Text;
            double tb = Double.Parse(txtTB.Text);
            double bb = Double.Parse(txtBB.Text);
            string jk = " ";
            if (btLk.IsChecked == true)
            {
                jk = "Laki-laki";
            }
            else if (btPr.IsChecked == true)
            {
                jk = "Perempuan";
            }
            Hal2 h = new Hal2(nama, ttl, usia, tb, bb, jk);
            h.Show();
        }
    }
}
