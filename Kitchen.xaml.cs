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
    /// Interaction logic for kitchen.xaml
    /// </summary>
    public partial class kitchen : Window
    {
        int life = 0;
        int[] array = new int[8];
        int noBtn = 0;
        string msg="";
        string[] msgAll = { "אני אוהב המבורגר אבל זה לא בריא לאכול המון",
            "אני לא רוצה עוד צ'יפס",
            "אין כמו חביתה בריאה! ",
            "אני לא רוצה עוד עוף",
            "נראה לי שאכלתי מספיק מעדנים להיום",
            " עומד להיות לי כאב בטן...",
            "מילקשייק זה מאוד טעים אבל אני לא אצליח ללכת לישון!",
            "תודה על המים!עכשיו אני כבר לא צמא"
        };
        public kitchen()
        {
            InitializeComponent();
        }

        private void Btnfood_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
           
                if (btn != null)
                {
                   int i = int.Parse(btn.Tag.ToString());
                    array[i]++;

                if (array[0] > 2) // המבורגר
                {
                    msg = msgAll[0];
                    array[0] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life - 1;
                }
                if (array[1] > 2) //  צ'יפס
                {
                    msg = msgAll[1];
                    array[1] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life - 1;
                }
                if (array[2] > 2) //  חביתה
                {
                    msg = msgAll[2];
                    array[2] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life + 2;
                }
                if (array[3] > 2) // עוף
                {
                    msg = msgAll[3];
                    array[3] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life + 1;
                }
                if (array[4] > 2) //מוזלי
                {
                    msg = msgAll[4];
                    array[4] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life + 1;
                }
                if (array[5] > 2) //פסטה
                {
                    msg = msgAll[5];
                    array[5] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life - 2;
                }
                if (array[6] > 2) //מילקשייק
                {
                    msg = msgAll[6];
                    array[6] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life - 2;
                }
                if (array[7] > 2) //מים
                {
                    msg = msgAll[7];
                    array[7] = 0;
                    btn.IsEnabled = false;
                    noBtn++;
                    life = life + 2;
                }
                lifeCounter.Content = life.ToString();

                if (msg == msgAll[i])
                {
                    MessageBox.Show(msg, "MessageBox", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation, MessageBoxResult.Cancel);
                }
                if (life >= 10)
                {
                    Winner winner = new Winner();
                    this.Close();
                    winner.Show();
                }
                if(noBtn==8)
                {
                    Lose lose = new Lose();
                    this.Close();
                    lose.Show();
                }
            }
        }
        
        private static int NewMethod(Button btn)
        {
            return int.Parse(btn.Tag.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Madregot madregot = new Madregot();
            madregot.Show();
            this.Close();
        }
    }
}


