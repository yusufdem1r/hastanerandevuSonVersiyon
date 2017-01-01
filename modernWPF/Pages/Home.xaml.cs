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
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
namespace modernWPF.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = hastane; Uid = root; Pwd=;");
        public Home()
        {
            InitializeComponent();
            
            BitmapImage res = new BitmapImage(new Uri("../resim/logo.png", UriKind.Relative));
            resim.Source = res;
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand girisyap = new MySqlCommand("Select * from uyeler where tc='" + giristc.Text.ToString() + "' and sifre = '" + girissifre.Password.ToString() + "'", bag);
            MySqlDataReader rd = girisyap.ExecuteReader();
            if ((giristc.Text=="admin")&&(girissifre.Password=="123"))
            {
                FirstFloor.ModernUI.Presentation.LinkGroup menugrubu = new FirstFloor.ModernUI.Presentation.LinkGroup();
                menugrubu.DisplayName = "Hosgeldinn Admins";
                FirstFloor.ModernUI.Presentation.Link linkeklenecek = new FirstFloor.ModernUI.Presentation.Link();
                linkeklenecek.DisplayName = "ADMİN PANELİ";
                linkeklenecek.Source = new Uri("Pages/BasicPage1.xaml", UriKind.Relative);

                menugrubu.Links.Add(linkeklenecek);
                MainWindow ab = Application.Current.MainWindow as MainWindow;
                ab.MenuLinkGroups.Clear();
                ab.MenuLinkGroups.Add(menugrubu);
                bag.Close();



            }
           
            else if (rd.Read())
            {
                FirstFloor.ModernUI.Presentation.LinkGroup menugrubu = new FirstFloor.ModernUI.Presentation.LinkGroup();
                menugrubu.DisplayName = "Hosgeldiniz";
                FirstFloor.ModernUI.Presentation.Link linkeklenecek = new FirstFloor.ModernUI.Presentation.Link();
                FirstFloor.ModernUI.Presentation.Link linkeklenecek2 = new FirstFloor.ModernUI.Presentation.Link();
                FirstFloor.ModernUI.Presentation.Link linkeklenecek3 = new FirstFloor.ModernUI.Presentation.Link();
                linkeklenecek.DisplayName = "RANDEVU AL";
                linkeklenecek2.DisplayName = "RANDEVULARI GÖR";
                linkeklenecek3.DisplayName = "ÜYE BİLGİLERİNİ GÜNCELLE";
                linkeklenecek.Source = new Uri("Pages/randevu.xaml", UriKind.Relative);
                linkeklenecek2.Source = new Uri("Pages/radevutakip.xaml", UriKind.Relative);
                linkeklenecek3.Source = new Uri("Pages/uyeguncelle.xaml", UriKind.Relative);


                menugrubu.Links.Add(linkeklenecek);
                menugrubu.Links.Add(linkeklenecek2);
                menugrubu.Links.Add(linkeklenecek3);
                MainWindow ab = Application.Current.MainWindow as MainWindow;
                ab.MenuLinkGroups.Clear();
                ab.MenuLinkGroups.Add(menugrubu);
                bag.Close();

            }
            else
            {
                Diaglog.hatamsj HATA = new Diaglog.hatamsj();
                HATA.ShowDialog();
                bag.Close();

            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            Diaglog.ModernDialog1 md = new Diaglog.ModernDialog1();
            md.ShowDialog();
          
            if (md.DialogResult.Value == true)
            {

                //MySqlCommand girisyap2 = new MySqlCommand("Select * from uyeler where tc='" + md.tcno.Text.ToString() + "'", bag);
                //MySqlDataReader oku = girisyap2.ExecuteReader();

                bag.Open();
                MySqlCommand ekle = new MySqlCommand("INSERT INTO uyeler(tc,ad,soyad,cinsiyet,dYeri,dTarihi,babaad,annead,eposta,sifre) VALUES ('" + md.tcno.Text + "','" + md.ad.Text + "','" + md.soyad.Text + "','" + md.cinsiyet.Text + "','" + md.dyeri.Text + "','" + md.tarih.Text + "','" + md.babaad.Text + "','" + md.annead.Text + "','" + md.eposta.Text + "','" + md.sifre.Password + "')", bag);
                    ekle.ExecuteNonQuery();
                    ekle.Dispose();
                    bag.Close();
                    MessageBox.Show((md.cinsiyet.Text).ToString());
                

            }
            else
            {
                MessageBox.Show("cancel");
            }

        }
    }
}
