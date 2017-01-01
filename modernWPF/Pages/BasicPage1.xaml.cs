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
    /// Interaction logic for BasicPage1.xaml
    /// </summary>
    public partial class BasicPage1 : UserControl
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        DispatcherTimer zaman;
        public BasicPage1()
        {
            InitializeComponent();
           
            zaman = new DispatcherTimer();
            zaman.Interval = new TimeSpan(0, 0, 8);
            zaman.Tick += Zaman_Tick;
            zaman.Start();

            cinsiyet.Items.Add("Erkek");
            cinsiyet.Items.Add("Kız");

        }
       
        private void Zaman_Tick(object sender, EventArgs e)
        {
            MySqlCommand asd = new MySqlCommand("Select * from uyeler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            dg1.ItemsSource = ta.AsDataView();


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
            MySqlCommand guncelle = new MySqlCommand("update uyeler set ad='"+ad.Text+"',soyad='"+soyad.Text+"',tc='"+tcno.Text+"',cinsiyet='"+cinsiyet.Text+"',dYeri='"+dyeri.Text+"',dTarihi='"+tarih.Text+"',babaad='"+babaad.Text+"',annead='"+annead.Text+"',eposta='"+eposta.Text+"',sifre='"+sifre.Text+"' where tc='" + tcno.Text+ "'", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(guncelle);
            guncelle.ExecuteNonQuery();
            guncelle.Dispose();
            bag.Close();
        }

        
    }
}
