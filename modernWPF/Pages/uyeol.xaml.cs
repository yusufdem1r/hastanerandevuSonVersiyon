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
using System.Windows.Threading;
using System.Data;
using MySql.Data.MySqlClient;
namespace modernWPF.Pages
{
    /// <summary>
    /// Interaction logic for uyeol.xaml
    /// </summary>
    public partial class uyeol : UserControl
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        public uyeol()
        {
            InitializeComponent();
            cinsiyet.Items.Add("Erkek");
            cinsiyet.Items.Add("Kız");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow abc = Application.Current.MainWindow as MainWindow;
            abc.MenuLinkGroups.Clear();
            abc.ContentSource = new Uri("Pages/Home.xaml", UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO uyeler(tc,ad,soyad,cinsiyet,dYeri,dTarihi,babaad,annead,eposta,sifre) VALUES ('" + tcno.Text + "','" + ad.Text + "','" + soyad.Text + "','" + cinsiyet.Text + "','" + dyeri.Text + "','" + tarih.Text + "','" + babaad.Text + "','" + annead.Text + "','" + eposta.Text + "','" + sifre.Password + "')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
            

        }
    }
}
