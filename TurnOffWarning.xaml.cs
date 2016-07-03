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
using System.Windows.Threading;

namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для TurnOffWarning.xaml
    /// </summary>
    public partial class TurnOffWarning : Window
    {
        int TurnOfTime = MemoryBuffer.TurnOfTimeToCancel;
        DispatcherTimer TurnOfTimer = new System.Windows.Threading.DispatcherTimer();
        
        public TurnOffWarning()
        {
            
 
            InitializeComponent();

            TurnOfTimer.Interval = TimeSpan.FromSeconds(1);
            txtWarningTimer.Text = TurnOfTime.ToString();
            TurnOfTimer.Tick += TurnOfTimer_Tick;
            TurnOfTimer.Start();
            Duration duration = new Duration(TimeSpan.FromSeconds((double)TurnOfTime));
            //DoubleAnimation animation
            //PrBTimerVisualization.BeginAnimation(duration
            
            
            
        }

        void TurnOfTimer_Tick(object sender, EventArgs e)
        {
            if (TurnOfTime != 0)
            {
                TurnOfTime--;
                txtWarningTimer.Text = TurnOfTime.ToString();
                //PrBTimerVisualization.SetValue(DependencyProperty.UnsetValue, TurnOfTime);
                
            }
            else
                TurnOfTimer.Stop();
                
        }
    }
}
