using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTimer.AdditionalButtons;
using Time;

namespace WPFTimer
{
    static class MemoryBuffer
    {
        public static List<MyTimeButton> FavTimeButtons = new List<MyTimeButton>();
        
        public static List<MyDeleteButton> FavDelButtons = new List<MyDeleteButton>();
        //?
        public static List<TimeSettings> FavTimeData = new List<TimeSettings>();

        public static StateEnum Timer;
        public static int StartingTime { get; set; }
        public static int TotalSeconds { get; set; }

        
        static MemoryBuffer()
        {
          
            Timer = StateEnum.Off;
            TotalSeconds = 0;
        }
    }
    
}
