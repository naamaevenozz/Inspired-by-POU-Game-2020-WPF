using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for shower.xaml
    /// </summary>
    public partial class shower : Window
    {
        int life = 0;
        int[] array = new int[6];
        string msg = null;
        string[] msgAll = { "You have to wash me first" ,
       "You have to brash my hair first",
        };
        public shower()
        {
            InitializeComponent();
        }

        private void Shower_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

                if (btn != null)
                {
                    int i = int.Parse(btn.Tag.ToString());

                switch (i)
                {
                    case 0:   //מגבת
                        {
                            if (array[4] == 2 && array[2] == 1 && array[3] == 1)
                            {
                                msg = null;
                                life++;
                                array[0]++;
                                btn.IsEnabled = false;
                            }
                            else
                                msg = msgAll[0];

                            break;
                        }
                    case 1:  //  מברשת
                        {
                            if (array[4] == 2 && array[2] == 1 && array[3] == 1 && array[0] == 1)
                            {
                                msg = null;
                                life++;
                                array[1]++;
                                btn.IsEnabled = false;
                            }
                            else
                                msg = msgAll[0];
                            break;
                        }
                    case 2:  //  סבון
                        {
                            if (array[4] == 1)
                            {
                                msg = null;
                                life++;
                                array[2]++;
                                btn.IsEnabled = false;
                            }
                            else
                                msg = msgAll[0];
                            break;
                        }
                    case 3:   // ספוג
                        {
                            if (array[2] == 1 && array[4] == 1)
                            {
                                msg = null;
                                life++;
                                array[3]++;
                                btn.IsEnabled = false;
                            }
                            else
                                msg = msgAll[0];
                            break;
                        }
                    case 4:    //מים בדוש
                        {
                            array[4]++;
                            life++;
                            msg = null;
                            if (array[4] == 2)
                                btn.IsEnabled = false;
                            break;
                        }
                    case 5:   //צחצוח שיניים
                        {
                            if (array[4] == 2 && array[0] == 1 && array[1] == 1 && array[2] == 1 && array[3] == 1)
                            {
                                msg = null;
                                life++;
                                array[5]++;
                                btn.IsEnabled = false;
                            }
                            else
                                msg = msgAll[1];
                            break;
                        }
                       }

                LifeCounter.Content = life.ToString();

                if (msg!=null)
                {
                    MessageBox.Show(msg, "MessageBox", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation, MessageBoxResult.Cancel);
                }
                if (life == 7)
                {
                   
                    Winner winner = new Winner();
                    winner.Show();
                    this.Close();
                    
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Madregot madregot = new Madregot();
            madregot.Show();
            
        }
    }
}