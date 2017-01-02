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
    /// Interaction logic for randevu.xaml
    /// </summary>
    public partial class randevu : UserControl
    {
        DispatcherTimer zaman;
        DataTable tablo = new DataTable();
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
       
        public randevu()
        {
            zaman = new DispatcherTimer();
            InitializeComponent();
            hastanead.Items.Add ( "Eyüp Devlet");
            hastanead.Items.Add("Okmeydanı Araştırma Hastanesi");
            hastanead.Items.Add("Taksim İlkyardım Hastanesi");
            klinik.Items.Add("Ortopedi");
            klinik.Items.Add("Dahiliye");
            klinik.Items.Add("Cildiye");
            klinik.Items.Add("Genel Cerrahi");
            klinik.Items.Add("Enfeksiyon");
            klinik.Items.Add("Kulak-Burun ve Boğaz Hastalıkları");
            doktor.Items.Add("Yusuf Demir");
            doktor.Items.Add("Melih Süzer");
            doktor.Items.Add("Can Akpınar");
            doktor.Items.Add("Ayşe Yılmaz");
            doktor.Items.Add("Tuğba Laçin");
            saat.Items.Add("08:00");
            saat.Items.Add("09:00");
            saat.Items.Add("10:00");
            saat.Items.Add("11:00");
            saat.Items.Add("12:00");
            saat.Items.Add("13:00");
            saat.Items.Add("14:00");
            saat.Items.Add("15:00");
            saat.Items.Add("16:00");
            saat.Items.Add("17:00");
            saat.Items.Add("18:00");
            saat.Items.Add("19:00");
            saat.Items.Add("20:00");
            bag.Open();
            MySqlCommand asd = new MySqlCommand("Select tc,ad,soyad,dTarihi from uyeler where  tc=(Select tc from giris  order by id desc LIMIT 1) ", bag);
            //MySqlDataAdapter ad = new MySqlDataAdapter(asd);
           
            MySqlDataAdapter adaptor = new MySqlDataAdapter(asd);
          
            adaptor.Fill(tablo);
            dg2.ItemsSource=tablo.AsDataView();
            zaman.Interval = new TimeSpan(0, 0, 1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();

            //asd.Dispose();
        }
        public void goster()
        {
            MySqlCommand asd2 = new MySqlCommand("Select tc,ad,soyad,dTarihi from uyeler where  tc=(Select tc from giris  order by id desc LIMIT 1) ", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd2);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            dg2.ItemsSource = ta.AsDataView();
        }
        private void Zaman_Tick(object sender, EventArgs e)
        {

            goster();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow abc = Application.Current.MainWindow as MainWindow;
            abc.MenuLinkGroups.Clear();
            abc.ContentSource = new Uri("Pages/Home.xaml", UriKind.Relative);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlConnection bag2 = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
            bag2.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO hastaneler(tc,hastaneAd,klinikAd,doktorAd,tarih,saat) VALUES ((Select tc from uyeler where  tc=(Select tc from giris  order by id desc LIMIT 1)),'" + hastanead.Text+"','"+klinik.Text+"','"+doktor.Text+"','"+tarih.Text+"','"+saat.Text+"')", bag2);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag2.Close();
        }
    }
}
