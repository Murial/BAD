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

namespace BelajarNavigasi2
{
    /// <summary>
    /// Interaction logic for Halaman2.xaml
    /// </summary>
    public partial class Halaman2 : Window
    {
        public Halaman2()
        {
            InitializeComponent();
        }

        private void btnKedua_Klik(object sender, RoutedEventArgs e)
        {
            Halaman1 hal1 = new Halaman1();
            hal1.Show();
            this.Close();
        }
    }
}
