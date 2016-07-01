using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFTimer.AdditionalButtons
{
    public class MyTimeButton : Button
    {
            

            public MyTimeButton(string TB )
            {
                
                Viewbox VB = new Viewbox();
                VB.Child = new TextBlock() {Text=TB};
                Content = VB;
                Background = new SolidColorBrush(Colors.White);

            }
        
    }
}
