using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFTimer.AdditionalButtons
{
    public class MyDeleteButton:Button
    {
        public MyDeleteButton()
        {
            Background = new SolidColorBrush(Colors.White);
            Image pc = new Image();
            BitmapImage bi = new BitmapImage();

            bi.BeginInit();
            bi.UriSource = new Uri(@"Resources\Cross3.ico", UriKind.Relative);
            bi.EndInit();

            pc.Source = bi;
            Content = pc;

        }
    }
    
}
