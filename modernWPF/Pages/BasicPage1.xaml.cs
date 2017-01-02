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
            goster();
            cinsiyet.Items.Add("Erkek");
            cinsiyet.Items.Add("Kız");

        }
        public void goster()
        {
            MySqlCommand asd = new MySqlCommand("Select tc,cinsiyet,ad,soyad,sifre,dTarihi,dYeri,eposta,annead,babaad from uyeler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            dg1.ItemsSource = ta.AsDataView();
        }
        private void Zaman_Tick(object sender, EventArgs e)
        {
            goster();
            zaman.Stop();


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
            if (dg1.SelectedIndex == -1) return;
            MySqlCommand guncelle = new MySqlCommand("update uyeler set ad='"+ad.Text+"',soyad='"+soyad.Text+"',tc='"+tcno.Text+"',cinsiyet='"+cinsiyet.Text+"',dYeri='"+dyeri.Text+"',dTarihi='"+tarih.Text+"',babaad='"+babaad.Text+"',annead='"+annead.Text+"',eposta='"+eposta.Text+"',sifre='"+sifre.Text+"' where tc='" + tcno.Text+ "'", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(guncelle);
            guncelle.ExecuteNonQuery();
            guncelle.Dispose();
            bag.Close();
            
            zaman.Interval = new TimeSpan(0, 0, 1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedIndex == -1) { return; }
            bag.Open();
            DataRowView satir = (DataRowView)dg1.SelectedItem;
           
            MySqlCommand sil = new MySqlCommand("delete from uyeler where tc='" + satir[0] + "'", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(sil);
            sil.ExecuteNonQuery();
            sil.Dispose();
            bag.Close();
            zaman.Interval = new TimeSpan(0, 0, 1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            zaman.Interval = new TimeSpan(0, 0, 1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();

        }
    }
}
