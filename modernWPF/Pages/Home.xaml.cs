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

namespace modernWPF.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((ad.Text=="admin")&&sifre.Password=="123")
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
              
               
                
            }
            else if((ad.Text == "basic") && (sifre.Password == "123"))
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

            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ");

            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Diaglog.ModernDialog1 md = new Diaglog.ModernDialog1();
            md.ShowDialog();
            //if (md.DialogResult.Value == true)
            //{
            //    MessageBox.Show("oku tıkladın");

            //}
            //else
            //{
            //    MessageBox.Show("cancel");
            //}

        }
    }
}
