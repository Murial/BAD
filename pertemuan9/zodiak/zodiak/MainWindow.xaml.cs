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

namespace zodiak
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

        public void proses(object sender, RoutedEventArgs e)
        {
            var tanggal = int.Parse(tanggal_lahir.Text);
            var bulan = int.Parse(bulan_lahir.Text);
            var tahun = int.Parse(tahun_lahir.Text);
            int tahun_now = DateTime.Today.Year;

            //HASIL
            int hasil_hitung = tahun_now - tahun;
            hasil.Text = hasil_hitung + " Tahun";

            //TANGGAL LAHIR
            var tanggal_raw = new DateTime(tahun, bulan, tanggal);
            var tanggal_number = tanggal_raw.ToString("dd MMMM yyyy");
            hasil_tanggal.Content = tanggal_number;

            //HARI LAHIR
            var hari_lahir = tanggal_raw.ToString("dddd");
            hasil_hari.Content = hari_lahir;

            //ZODIAK
            string zodiak = "";

            if ((tanggal >= 21 && bulan == 3) || (tanggal <= 19 && bulan == 4))
            {
                zodiak = "Aries";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 20 && bulan == 4) || (tanggal <= 20 && bulan == 5))
            {
                zodiak = "Taurus";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 21 && bulan == 5) || (tanggal <= 20 && bulan == 6))
            {
                zodiak = "Gemini";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 21 && bulan == 6) || (tanggal <= 22 && bulan == 7))
            {
                zodiak = "Cancer";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 23 && bulan == 7) || (tanggal <= 22 && bulan == 8))
            {
                zodiak = "Leo";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 23 && bulan == 8) || (tanggal <= 22 && bulan == 9))
            {
                zodiak = "Virgo";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 23 && bulan == 9) || (tanggal <= 22 && bulan == 10))
            {
                zodiak = "Libra";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 23 && bulan == 10) || (tanggal <= 21 && bulan == 11))
            {
                zodiak = "Scorpio";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 22 && bulan == 11) || (tanggal <= 21 && bulan == 12))
            {
                zodiak = "Saggitarius";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 22 && bulan == 12) || (tanggal <= 19 && bulan == 1))
            {
                zodiak = "Capricorn";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 20 && bulan == 1) || (tanggal <= 18 && bulan == 2))
            {
                zodiak = "Aquarius";
                hasil_zodiak.Content = zodiak;
            }
            else if ((tanggal >= 19 && bulan == 2) || (tanggal <= 20 && bulan == 3))
            {
                zodiak = "Pisces";
                hasil_zodiak.Content = zodiak;
            }        
                       
            //SHIO
            string shio = "";
            int tahun_shio = tahun % 12;

            if (tahun_shio == 0)
            {
                shio = "Monyet";
                hasil_shio.Content = shio;
            }   
            else if (tahun_shio == 1)
            {
                shio = "Ayam";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 2)
            {
                shio = "Anjing";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 3)
            {
                shio = "Babi";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 4)
            {
                shio = "Tikus";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 5)
            {
                shio = "Kerbau";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 6)
            {
                shio = "Macan";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 7)
            {
                shio = "Kelinci";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 8)
            {
                shio = "Naga";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 9)
            {
                shio = "Ular";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 10)
            {
                shio = "Kerbau";
                hasil_shio.Content = shio;
            }
            else if (tahun_shio == 11)
            {
                shio = "Kambing";
                hasil_shio.Content = shio;
            }

            //UNSUR
            string unsur = "";
            string tahun_str = tahun.ToString();
            char last = tahun_str.Last();

            switch (last)
            {
                case '0' :
                     hasil_unsur.Content = "Logam";
                    break;
                case '1':
                    hasil_unsur.Content = "Logam";
                    break;
                case '2':
                    hasil_unsur.Content = "Air";
                    break;
                case '3':
                    hasil_unsur.Content = "Air";
                    break;
                case '4':
                    hasil_unsur.Content = "Kayu";
                    break;
                case '5':
                    hasil_unsur.Content = "Kayu";
                    break;
                case '6':
                    hasil_unsur.Content = "Api";
                    break;
                case '7':
                    hasil_unsur.Content = "Api";
                    break;
                case '8':
                    hasil_unsur.Content = "Tanah";
                    break;
                case '9':
                    hasil_unsur.Content = "Tanah";
                    break;
            }
        }
    }
}
