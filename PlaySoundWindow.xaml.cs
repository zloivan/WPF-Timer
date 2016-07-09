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



using System.Media;namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для PlaySoundWindow.xaml
    /// </summary>
    public partial class PlaySoundWindow : Window
    {
        public PlaySoundWindow()
        {
            InitializeComponent();
            using (var plr = new SoundPlayer(Properties.Resources.Alarm_Classic))
            {
                for (int i = 0; i < 10; i++)
                {
                    plr.PlayLooping();
                    
                }
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
