using System.Collections.Generic;
using WPFTimer.AdditionalButtons;
using Time;
using WPFTimer.Enums;


namespace WPFTimer
{
    static class MemoryBuffer
    {
        public static RBStateEnum _RBStateEnum;
        public static List<MyTimeButton> FavTimeButtons = new List<MyTimeButton>();
        
        public static List<MyDeleteButton> FavDelButtons = new List<MyDeleteButton>();
        //?
        public static List<TimeSettings> FavTimeData = new List<TimeSettings>();

        public static StateEnum _Timer;
        public static int StartingTime { get; set; }
        public static int TotalSeconds { get; set; }

        
        static MemoryBuffer()
        {
            _RBStateEnum = RBStateEnum.PlaySound;
            _Timer = StateEnum.Off;
            TotalSeconds = 0;
        }
    }
    
}
