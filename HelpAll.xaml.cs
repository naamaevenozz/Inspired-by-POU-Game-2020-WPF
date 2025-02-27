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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for HelpAll.xaml
    /// </summary>
    public partial class HelpAll : Window
    {
        public HelpAll()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            HelpS helpS = new HelpS();
            helpS.Show();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
           
            HelpK helpK = new HelpK();
            helpK.Show();
            this.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Madregot madregot = new Madregot();
            madregot.Show();
            this.Close();
        }
    }
}
