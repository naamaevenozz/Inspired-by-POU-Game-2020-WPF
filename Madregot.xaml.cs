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
    /// Interaction logic for Madregot.xaml
    /// </summary>
    public partial class Madregot : Window
    {
        public Madregot()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kitchen kitchen = new kitchen();
            this.Close();
            kitchen.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HelpAll help = new HelpAll();
            this.Close();
            help.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            shower shower = new shower();
            this.Close();
            shower.Show();
        }
    }
}
