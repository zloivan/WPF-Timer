using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Timer.TimerC;

namespace Timer.Settings
{
    public static class CSettings
    {
        static CSettings()
        {
            Time = 15;
            Minutes.TimeValue = 0;
            Seconds.TimeValue = 0;
            Hours.TimeValue = 0;
            OperationOption = Operations.DoNothing;
            MemoryOn = true;
        }
        public static int Time { get; set; }
        static TimerCLass _minutes=new TimerCLass();
        static TimerCLass _seconds = new TimerCLass();
        static TimerCLass _hours = new TimerCLass();

        public static int MemorySeconds { get; set; }
        public static int MemoryMinutes { get; set; }
        public static int MemoryHours { get; set; }

        public static TimerCLass Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }
        public static void AllClear()
        {
            Minutes.TimeValue = 0;
            Seconds.TimeValue = 0;
            Hours.TimeValue = 0;
        }
        public static void ResumeInfo()
        {
            Minutes.TimeValue = MemoryMinutes;
            Seconds.TimeValue = MemorySeconds;
            Hours.TimeValue = MemoryHours;
        }

        public static TimerCLass Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }
        public static TimerCLass Hours 
        {
            get { return _hours; }
            set { _hours = value; } 
        }
        public static void SettingsToDefault()
        {
            Time = 15;
            Minutes.TimeValue = 0;
            Seconds.TimeValue = 0;
            Hours.TimeValue = 0;
            OperationOption = Operations.DoNothing;
            MemoryOn = true;
        }
        
        public static Operations OperationOption { get; set; }
        public static bool MemoryOn { get; set; }
    }
}
