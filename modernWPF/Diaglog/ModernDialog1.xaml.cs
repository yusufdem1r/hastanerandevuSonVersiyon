using FirstFloor.ModernUI.Windows.Controls;
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

namespace modernWPF.Diaglog
{
    /// <summary>
    /// Interaction logic for ModernDialog1.xaml
    /// </summary>
    public partial class ModernDialog1 : ModernDialog
    {
        public ModernDialog1()
        {
            InitializeComponent();

            // define the dialog buttons
            this.Buttons = new Button[] { this.OkButton, this.CancelButton };
            cinsiyet.Items.Add("Erkek");
            cinsiyet.Items.Add("Kız");
            //Diaglog.ModernDialog1 md = new Diaglog.ModernDialog1();
            //md.ShowDialog();
            //if (md.DialogResult.Value == true)
            //{
            //    MessageBox.Show("tıkladın");

            //}
            //else
            //{
            //    MessageBox.Show("cancel");
            //}
        }
    }
}
