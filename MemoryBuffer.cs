using System.Collections.Generic;
using WPFTimer.AdditionalButtons;
using Time;
using WPFTimer.Enums;
using System;


namespace WPFTimer
{
    static class MemoryBuffer
    {
        public static SettingRadioButtonsState ChosenRadioButtonState { get; set; }
        public static int TurnOfTimeToCancel {get;set;}

        public static List<MyTimeButton> FavTimeButtons = new List<MyTimeButton>();
        
        public static List<MyDeleteButton> FavDelButtons = new List<MyDeleteButton>();
        
        public static List<TimeSettings> FavTimeData = new List<TimeSettings>();

        public static TimerState CurrentState{get;set;}
        public static int StartingTime { get; set; }
        public static int TotalSeconds { get; set; }

        
        static MemoryBuffer()
        {
            ChosenRadioButtonState = SettingRadioButtonsState.PlaySound;
            CurrentState = TimerState.Off;
            TotalSeconds = 0;
            TurnOfTimeToCancel = 10;
        }
    }
    
}
