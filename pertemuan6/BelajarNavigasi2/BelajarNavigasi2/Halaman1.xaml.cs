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

namespace BelajarNavigasi2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Halaman1 : Window
    {
        public Halaman1()
        {
            InitializeComponent();
        }

        private void btnPertama_Klik(object sender, RoutedEventArgs e)
        {
            Halaman2 hal2 = new Halaman2();
            hal2.Show();
            this.Close();
        }
    }
}
