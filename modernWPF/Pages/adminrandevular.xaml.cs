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
    /// Interaction logic for adminrandevular.xaml
    /// </summary>
    public partial class adminrandevular : UserControl
    {
        DispatcherTimer zaman;
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        MySqlConnection bag2 = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        public adminrandevular()
        {
            zaman = new DispatcherTimer();
            InitializeComponent();
          
            DataTable tablo = new DataTable();
           
            bag.Open();
            MySqlCommand asd = new MySqlCommand("Select * from hastaneler" , bag);

            MySqlDataAdapter adaptor = new MySqlDataAdapter(asd);

            adaptor.Fill(tablo);
            dg1.ItemsSource = tablo.AsDataView();
        }

        public void goster()
        {
            MySqlCommand asd2 = new MySqlCommand("Select * from hastaneler ", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd2);
            DataTable tablo = new DataTable();
            ad.Fill(tablo);
            dg1.ItemsSource = tablo.AsDataView();

        }
        private void Zaman_Tick(object sender, EventArgs e)
        {

            goster();
            zaman.Stop();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
            zaman.Interval = new TimeSpan(0, 0, 2);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow abc = Application.Current.MainWindow as MainWindow;
            abc.MenuLinkGroups.Clear();
            abc.ContentSource = new Uri("Pages/Home.xaml", UriKind.Relative);
        }
    }
}
