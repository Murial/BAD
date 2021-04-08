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

        private void print_pesan(object sender, RoutedEventArgs e)
        {
            var nama_makanan = new[] { "Nasi", "Ikan Gurame Bakar", "Cumi Asam Manis", "Tumis Kangkung", "Tahu Goreng", "Ayam Goreng" };
            var nama_minuman = new[] { "Teh Manis", "Jus Mangga", "Jus Alpukat", "Lemon Tea", "Milk Shake"};
            var harga_makanan = new[] { 5000, 60000, 45000, 15000, 5000, 12000 };
            var harga_minuman = new[] { 4000, 8000, 8000, 5000, 9000};

            var total_nama_makanan = makanan.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => nama_makanan[makanan.Items.IndexOf(x)]);
            var total_nama_minuman = minuman.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => nama_minuman[minuman.Items.IndexOf(x)]);

            var total_nama =  total_nama_makanan.Concat(total_nama_minuman);

            var total_harga_makanan = makanan.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => harga_makanan[makanan.Items.IndexOf(x)]).Sum();
            var total_harga_minuman = minuman.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => harga_minuman[minuman.Items.IndexOf(x)]).Sum();

            var total_harga = total_harga_makanan + total_harga_minuman;

            total.Text = "Rp." + string.Join(", ", total_harga) + ",00";

            MessageBox.Show("Pesanan Anda : \n" + string.Join("\n ", total_nama));
        }
    }
}
