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
using WPFTimer;
using System.Windows.Media.Animation;

namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для TurnOffWarning.xaml
    /// </summary>
    public partial class TurnOffWarning : Window
    {
        int TurnOfTime = MemoryBuffer.TurnOfTimeToCancel;
        DispatcherTimer TurnOfTimer = new System.Windows.Threading.DispatcherTimer();
        public event EventHandler AdditionalTimeButtonClick;
        protected void OnAditionalButtonClick()
        {
            if (AdditionalTimeButtonClick != null)
            {
                AdditionalTimeButtonClick(this, EventArgs.Empty);
            }
        }
        public TurnOffWarning()
        {
            
 
            InitializeComponent();

            TurnOfTimer.Interval = TimeSpan.FromSeconds(1);
            txtWarningTimer.Text = TurnOfTime.ToString();
            TurnOfTimer.Tick += TurnOfTimer_Tick;
            TurnOfTimer.Start();
           
            
            
            
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
            {

                TurnOfTimer.Stop();
                var Finish = new FinishAction(MemoryBuffer.ChosenRadioButtonState);
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            TurnOfTimer.Stop();
            this.Close();
        }

        private void btn15min_Click(object sender, RoutedEventArgs e)
        {
            TurnOfTimer.Stop();
            this.Close();
            MemoryBuffer.TotalSeconds = 900;
            OnAditionalButtonClick();
            
            
        }

        private void btn30min_Click(object sender, RoutedEventArgs e)
        {
            TurnOfTimer.Stop();
            this.Close();
            MemoryBuffer.TotalSeconds = 1800;
            OnAditionalButtonClick();
        }

        private void btn1hour_Click(object sender, RoutedEventArgs e)
        {
            TurnOfTimer.Stop();
            this.Close();
            MemoryBuffer.TotalSeconds = 3600;
            OnAditionalButtonClick();
        }
    }
}
