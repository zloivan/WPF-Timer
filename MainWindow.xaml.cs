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
using Time;
using PCManagment;
using System.Windows.Threading;
using WPFTimer.AdditionalButtons;



namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        
       
        Hours h = new Hours();
        Minutes m = new Minutes();
        Seconds s = new Seconds();
        
        
            
        
        public MainWindow()
        {
            InitializeComponent();
            //после инициализации окна обновляется информация в textbox-ах.
            TextBoxDataRefresh();

            Timer.Tick+=new EventHandler(Timer_tick);
            Timer.Interval = new TimeSpan(0,0,1);

            RefreshFavButtons(MemoryBuffer.FavTimeButtons,MemoryBuffer.FavDelButtons);
            
        }

        #region Изменения значения текстбоксов
        private void HourUpBTN_Click(object sender, RoutedEventArgs e)
        {
            h.Next();
            HourTXTB.Text = h.ToString();
        }

        private void HourDownBTN_Click(object sender, RoutedEventArgs e)
        {
            h.Previe();
            HourTXTB.Text = h.ToString();
        }

        private void MinUpBTN_Click(object sender, RoutedEventArgs e)
        {
            m.Next();
            MinTXTB.Text = m.ToString();
        }

        private void MinDownBTN_Click(object sender, RoutedEventArgs e)
        {
            m.Previe();
            MinTXTB.Text = m.ToString();
        }

        private void SecUpBTN_Click(object sender, RoutedEventArgs e)
        {
            s.Next();
            SecTXTB.Text = s.ToString();
        }

        private void SecDownBTN_Click(object sender, RoutedEventArgs e)
        {
            s.Previe();
            SecTXTB.Text = s.ToString();
        }

        private void HourTXTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
          
            
        }
        private void MinTXTB_TextChanged(object sender, TextChangedEventArgs e)
        {
           

            
        }
        private void SecTXTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }
        //Метод обновляет данные в текстбоксах
        private void TextBoxDataRefresh()
        {
            s.TimeValue = s.GetSeconds(MemoryBuffer.TotalSeconds);
            m.TimeValue = m.GetMinutes(MemoryBuffer.TotalSeconds);
            h.TimeValue = h.GetHours(MemoryBuffer.TotalSeconds);
            HourTXTB.Text = h.ToString();
            MinTXTB.Text = m.ToString();
            SecTXTB.Text = s.ToString();
        }
        #endregion
        
        private void StartBTN_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryBuffer.Timer == StateEnum.Off)
            {
                
                h.TimeValue = Convert.ToInt32(HourTXTB.Text);
                m.TimeValue = Convert.ToInt32(MinTXTB.Text);
                s.TimeValue = Convert.ToInt32(SecTXTB.Text);
                MemoryBuffer.TotalSeconds = h.GetTotalSeconds() + m.GetTotalSeconds() + s.GetTotalSeconds();
                MemoryBuffer.StartingTime = MemoryBuffer.TotalSeconds;
                if (MemoryBuffer.TotalSeconds != 0)
                {
                    TimerON();
                    MemoryBuffer.Timer = StateEnum.On;
                    MemoryBuffer.TotalSeconds--;
                    TextBoxDataRefresh();
                    Timer.Start();
                }
            }
            else
                if(MemoryBuffer.Timer==StateEnum.On)
            {
                Timer.Stop();
                MemoryBuffer.TotalSeconds = MemoryBuffer.StartingTime;
                
                
                
                TimerOFF();
                TextBoxDataRefresh();
                MemoryBuffer.Timer = StateEnum.Off;
            }
                else if (MemoryBuffer.Timer == StateEnum.Paused)
                {
                    
                    MemoryBuffer.TotalSeconds = MemoryBuffer.StartingTime;
                    //TextBoxDataRefresh();

                    TimerOFF();
                    MemoryBuffer.Timer = StateEnum.Off;
                    TextBoxDataRefresh();
                }
                
        }
        private void Timer_tick(object sender, EventArgs e)
        {
            MemoryBuffer.TotalSeconds--;

            TextBoxDataRefresh();
            if (MemoryBuffer.TotalSeconds == 0) 
            {
                MemoryBuffer.Timer = StateEnum.Off;
                Timer.Stop();
                TimerOFF();
            }
        }
        #region Визуальные преображения с включением таймера
        private void TimerON()
        {
            BTNStartContent.Text = "Clear";
            PauseBTNContent.Text = "Pause";
            
            HourDownBTN.IsEnabled = false;
            HourUpBTN.IsEnabled = false;
            MinDownBTN.IsEnabled = false;
            MinUpBTN.IsEnabled = false;
            SecDownBTN.IsEnabled = false;
            SecUpBTN.IsEnabled = false;

            HourTXTB.IsReadOnly = true;
            MinTXTB.IsReadOnly = true;
            SecTXTB.IsReadOnly = true;
            PauseBTN.IsEnabled = true;
            Expander.IsEnabled = false;
           
        }
        private void TimerOFF()
        {
            BTNStartContent.Text = "Start";
            PauseBTNContent.Text = "Pause";
            HourDownBTN.IsEnabled = true;
            HourUpBTN.IsEnabled = true;
            MinDownBTN.IsEnabled = true;
            MinUpBTN.IsEnabled = true;
            SecDownBTN.IsEnabled = true;
            SecUpBTN.IsEnabled = true;
            HourTXTB.IsReadOnly = false;
            MinTXTB.IsReadOnly = false;
            SecTXTB.IsReadOnly = false;
            PauseBTN.IsEnabled = false;
            Expander.IsEnabled = true;

        }
        private void TimerPaused()
        {
            BTNStartContent.Text = "Clear";
            PauseBTNContent.Text = "Go On";
            
            HourDownBTN.IsEnabled = false;
            HourUpBTN.IsEnabled = false;
            MinDownBTN.IsEnabled = false;
            MinUpBTN.IsEnabled = false;
            SecDownBTN.IsEnabled = false;
            SecUpBTN.IsEnabled = false;
            
            HourTXTB.IsReadOnly = true;
            MinTXTB.IsReadOnly = true;
            SecTXTB.IsReadOnly = true;

            PauseBTN.IsEnabled = true;
            Expander.IsEnabled = false;

        }
        #endregion

        private void PauseBTN_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryBuffer.Timer == StateEnum.On)
            {
                Timer.Stop();
                MemoryBuffer.Timer = StateEnum.Paused;
                TimerPaused();
            }
            else
            {
                Timer.Start();
                MemoryBuffer.Timer = StateEnum.On;
                TimerON();
            }
        }

        private void AddFavBTN_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryBuffer.FavTimeButtons.Count <= 6)
            {
                MemoryBuffer.FavTimeButtons.Add(new MyTimeButton(String.Format("{0}:{1}:{2}", h.TimeValue, m.TimeValue, s.TimeValue)));
                MemoryBuffer.FavDelButtons.Add(new MyDeleteButton());
                MemoryBuffer.FavTimeData.Add(new TimeSettings(h, m, s));




                RefreshFavButtons(MemoryBuffer.FavTimeButtons, MemoryBuffer.FavDelButtons);

                MemoryBuffer.FavTimeButtons.Last().Click += (object sender2, RoutedEventArgs empty2) =>
                    {
                        var temp = (MyTimeButton)sender2;
                        int index = MemoryBuffer.FavTimeButtons.IndexOf(temp);
                        MemoryBuffer.TotalSeconds = MemoryBuffer.FavTimeData[index].SaveTimeDate;

                        TextBoxDataRefresh();
                    };

                MemoryBuffer.FavDelButtons.Last().Click += (object sender1, RoutedEventArgs empty) =>
                {
                    var a = (MyDeleteButton)sender1;

                    int index = MemoryBuffer.FavDelButtons.IndexOf(a);
                    MemoryBuffer.FavDelButtons.RemoveAt(index);
                    MemoryBuffer.FavTimeButtons.RemoveAt(index);
                    MemoryBuffer.FavTimeData.RemoveAt(index);

                    RefreshFavButtons(MemoryBuffer.FavTimeButtons, MemoryBuffer.FavDelButtons);

                };
            }
            
        }
        private void RefreshFavButtons(List<MyTimeButton> t, List<MyDeleteButton> d)
        {
            ExpanderGrid.Children.Clear();
            for (int i = 0; i < d.Count; i++)
            {
                Grid.SetColumn(t[i], 0);
                Grid.SetRow(t[i], i);
                Grid.SetColumn(d[i], 1);
                Grid.SetRow(d[i], i);
                ExpanderGrid.Children.Add(d[i]);
                ExpanderGrid.Children.Add(t[i]);
            }
        }

        private void SettingsBTN_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow SetWin = new SettingsWindow();
            SetWin.ShowDialog();
        }
    }
}
