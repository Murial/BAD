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

namespace pertemuan5
{
    /// <summary>
    /// Interaction logic for LatihanMenu.xaml
    /// </summary>
    public partial class LatihanMenu : Window
    {
        public LatihanMenu()
        {
            InitializeComponent();
        }

        private void total_pesan(object sender, RoutedEventArgs e)
        {

        }

        private void print_pesan(object sender, RoutedEventArgs e)
        {
            var cbDipilih = makanan.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => x.Content).ToList();

            MessageBox.Show(string.Join(", ", cbDipilih));
        }
    }
}
