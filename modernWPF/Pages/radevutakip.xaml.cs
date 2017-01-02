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
    /// Interaction logic for radevutakip.xaml
    /// </summary>
    public partial class radevutakip : UserControl
    {
        DispatcherTimer zaman;
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        DataTable tablo = new DataTable();
        public radevutakip()
        {
            zaman = new DispatcherTimer();
            InitializeComponent();
            bag.Open();
            MySqlCommand asd = new MySqlCommand("Select * from hastaneler where  tc=(Select tc from giris  order by id desc LIMIT 1) ", bag);
            //MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable tablo = new DataTable();
            MySqlDataAdapter adaptor = new MySqlDataAdapter(asd);
            zaman.Interval = new TimeSpan(0, 0, 5);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
            adaptor.Fill(tablo);
            dg1.ItemsSource = tablo.AsDataView();
        }
        public void goster()
        {
            MySqlCommand asd2 = new MySqlCommand("Select * from hastaneler where  tc=(Select tc from giris  order by id desc LIMIT 1) ", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd2);
            DataTable tablo = new DataTable();
            ad.Fill(tablo);
            dg1.ItemsSource = tablo.AsDataView();
           
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
            if (dg1.SelectedIndex == -1) { return; }
            MySqlConnection bag2 = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
            bag2.Open();
            DataRowView satir = (DataRowView)dg1.SelectedItem;
           
            MySqlCommand sil = new MySqlCommand("delete from hastaneler where id='" + satir[0].ToString() + "'", bag2);
            MySqlDataAdapter adabtor2 = new MySqlDataAdapter(sil);
            sil.ExecuteNonQuery();
            sil.Dispose();
            bag2.Close();
        }
    }
}
