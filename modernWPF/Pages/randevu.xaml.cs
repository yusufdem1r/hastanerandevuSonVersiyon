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
    }
}
