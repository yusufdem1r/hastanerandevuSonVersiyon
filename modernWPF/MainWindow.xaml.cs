using FirstFloor.ModernUI.Windows.Controls;
using modernWPF.Pages.Settings;
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

namespace modernWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    { 
        public MainWindow()
        {
            InitializeComponent();

            this.MenuLinkGroups.Clear();
            AppearanceViewModel a = new AppearanceViewModel();
            a.SelectedTheme = a.Themes[0];
            a.SelectedAccentColor = a.AccentColors[3];


        }
    }
}
