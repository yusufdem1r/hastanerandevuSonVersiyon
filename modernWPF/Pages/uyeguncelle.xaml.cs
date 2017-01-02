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
    /// Interaction logic for uyeguncelle.xaml
    /// </summary>
    public partial class uyeguncelle : UserControl
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        DispatcherTimer zaman;
        public uyeguncelle()
        {
            InitializeComponent();
            MySqlCommand asd = new MySqlCommand("Select * from uyeler where  tc=(Select tc from giris  order by id desc LIMIT 1)", bag);
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
        private void Zaman_Tick(object sender, EventArgs e)
        {

           
            

        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlConnection bag2 = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
            bag2.Open();
            if (dg1.SelectedIndex == -1) return;
            MySqlCommand guncelle = new MySqlCommand("update uyeler set ad='" + ad.Text + "',soyad='" + soyad.Text + "',tc='" + tcno.Text + "',cinsiyet='" + cinsiyet.Text + "',dYeri='" + dyeri.Text + "',dTarihi='" + tarih.Text + "',babaad='" + babaad.Text + "',annead='" + annead.Text + "',eposta='" + eposta.Text + "',sifre='" + sifre.Text + "' where tc='" + tcno.Text + "'", bag2);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(guncelle);
            guncelle.ExecuteNonQuery();
            guncelle.Dispose();
            bag2.Close();

        }
    }
}
