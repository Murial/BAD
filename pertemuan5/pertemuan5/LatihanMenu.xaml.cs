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
            var nama_makanan = new[] { "Nasi", "Ikan Gurame Bakar", "Cumi Asam Manis", "Tumis Kangkung", "Tahu Goreng", "Ayam Goreng"};
            var harga_makanan = new[] { 5000, 60000, 45000, 15000, 5000, 12000 };

            var total_harga = makanan.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => harga_makanan[makanan.Items.IndexOf(x)]).Sum();

            MessageBox.Show(string.Join(", ", total_harga));
        }
    }
}
