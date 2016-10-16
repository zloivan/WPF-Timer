using System.Collections.Generic;
using WPFTimer.AdditionalButtons;
using System.IO;
using WPFTimer.Enums;
using System;


namespace WPFTimer
{
    

    static class MemoryBuffer
    {
        public static bool CBClearCheched { get; set; }
        private static string _musicFileName;
        private static string _executingFileName;
        private static int _totalSeconds;
        public static SettingRadioButtonsState ChosenRadioButtonState { get; set; }
        public static int TurnOfTimeToCancel {get;set;}

        public static List<MyTimeButton> FavTimeButtons = new List<MyTimeButton>();
        
        public static List<MyDeleteButton> FavDelButtons = new List<MyDeleteButton>();
        
        public static event EventHandler TotalTimeChanged;
        public static event EventHandler MusicPathChanged;
        public static event EventHandler FilePathChanged;
        private static void OnTotalTimeChanging(int totalSeconds)
        {
            if(TotalTimeChanged!=null)
            {
                TotalTimeChanged(null, EventArgs.Empty);
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
        public static string MusicFileName 
        {
            get 
            {
                return _musicFileName;
            }
            set
            {
                _musicFileName = value;
                OnMusicFileNameChange();
            } 
        }
        public static string ExecutingFileName
        {
            get
            {
                return _executingFileName;
            }
            set
            {
                _executingFileName = value;
                OnFileNameChange();
            }
        }

        private static void OnMusicFileNameChange()
        {
            if (MusicPathChanged != null)
            {
                MusicPathChanged(null,EventArgs.Empty);
            }
        }
        private static void OnFileNameChange()
        {
            if (FilePathChanged != null)
            {
                FilePathChanged(null, EventArgs.Empty);
            }
        }

        
        static MemoryBuffer()
        {
            MusicFileName = "";
            ExecutingFileName = "";
            ChosenRadioButtonState = SettingRadioButtonsState.PlaySound;
            CurrentState = TimerState.Off;
            TotalSeconds = 0;
            TurnOfTimeToCancel = 10;

        }
    }
    
}
