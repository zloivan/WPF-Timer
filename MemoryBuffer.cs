using System.Collections.Generic;
using WPFTimer.AdditionalButtons;
using Time;
using WPFTimer.Enums;
using System;


namespace WPFTimer
{
    public class TimeEventArgs:EventArgs
    {
        public int TotalTime{get;set;}

        
    }

    static class MemoryBuffer
    {
        private static int _totalSeconds;
        public static SettingRadioButtonsState ChosenRadioButtonState { get; set; }
        public static int TurnOfTimeToCancel {get;set;}

        public static List<MyTimeButton> FavTimeButtons = new List<MyTimeButton>();
        
        public static List<MyDeleteButton> FavDelButtons = new List<MyDeleteButton>();
        
        public static event EventHandler<TimeEventArgs> TotalTimeChanged;
        
        private static void OnTotalTimeChanging(int totalSeconds)
        {
            if(TotalTimeChanged!=null)
            {
                TotalTimeChanged(null, new TimeEventArgs() { TotalTime = totalSeconds });
            }
        }
        public static List<int> FavTimeData = new List<int>();
        public static void PlusHour() { TotalSeconds += 3600; }
        public static void MinusHour() 
        {
            if (TotalSeconds >= 3600)
            {
                TotalSeconds -= 3600;
            }
            //else { TotalSeconds += 59 * 3600; }
        }
        public static void PlusMinute() { TotalSeconds += 60; }
        public static void MinusMinute() 
        {
            if (TotalSeconds >= 60)
                TotalSeconds -= 60;
            else 
            {
                TotalSeconds += 59 * 60;
            }
        }
        public static void PlusSecond() { TotalSeconds += 1; }
        public static void MinusSecond()
        {
            if (TotalSeconds >= 1)
                TotalSeconds -= 1;
            else
            {
                TotalSeconds += 59;
            }
        }
        public static int ReturnHours()
        {
            return TotalSeconds / 3600;
        }
        public static int ReturnMinutes()
        {
            return (TotalSeconds % 3600) / 60;
        }
        public static int ReturnSeconds()
        {
            return (TotalSeconds % 3600) % 60;
        }
        public static TimerState CurrentState{get;set;}
        public static int StartingTime { get; set; }
        public static int TotalSeconds 
        { 
            get 
            {
                return _totalSeconds;
            } 
            set 
            {
                _totalSeconds = value;
                OnTotalTimeChanging(value);
            }
        }

        
        static MemoryBuffer()
        {
            ChosenRadioButtonState = SettingRadioButtonsState.PlaySound;
            CurrentState = TimerState.Off;
            TotalSeconds = 0;
            TurnOfTimeToCancel = 10;
        }
    }
    
}
