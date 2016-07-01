using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    //Свойство задающее значение временых едениц (часов, минут, секунд) от 0 до 59
    public abstract class TimeEntities
    {
       
        int _timevalue;
        public int TimeValue 
        {
            get
            {
                return _timevalue;
            }
            set
            {
                if (value > 59)
                    _timevalue = 59;
                else
                    if (value < 0)
                        _timevalue = 0;
                    else _timevalue = value;
                
            }
        }
        //конструктор устанавливающий значение временной еденицы на ноль.
        public TimeEntities()
        {
            TimeValue = 0;
        }

        

        //Шаг на одну временную еденицу вперед
        public void Previe()
        {
            if (TimeValue==0) TimeValue = 59;
            else TimeValue--;
            
            
        }
        //Шаг на одну временную еденицу назад
        public void Next()
        {
            if (TimeValue == 59) TimeValue = 0;
            else TimeValue++;
        }
        public abstract int GetTotalSeconds();
        
        

    }
    public class Hours : TimeEntities
    {

        //Получение из общего колличества секунд колличество часов.
        public int GetHours(int seconds)
        {
            int result;
            {
                result = seconds / 3600;
                return result;
            }
        }
        public override int GetTotalSeconds()
        {
            return TimeValue * 3600;
        }
        public override string ToString()
        {
            string str = String.Format("{0}", TimeValue);
            return str;
        }
    }
    public class Minutes : TimeEntities
    {
        //Получение из общего колличества секунд колличества минут.
        public int GetMinutes(int seconds)
        {
            int result;
            {

                result = (seconds % 3600) / 60;
                return result;
            }
        }
        public override string ToString()
        {
            string str = String.Format("{0}", TimeValue);
            return str;
        }
        public override int GetTotalSeconds()
        {
            return TimeValue * 60;
        }
    }
    public class Seconds : TimeEntities
    {
        //Получение из общего колличества секунд секунд .
        public int GetSeconds(int seconds)
        {
            int result;
            {
                result = (seconds % 3600) % 60;
                return result;
            }
        }
        public override string ToString()
        {
            string str = String.Format("{0}", TimeValue);
            return str;
        }
        public override int GetTotalSeconds()
        {
            return TimeValue;
        }
    }
    public class TimeSettings : TimeEntities
    {
        private int _savetimedata;
        public int SaveTimeDate
        {
            get { return _savetimedata; } 
        }

        public TimeSettings(Hours h, Minutes m, Seconds s)
        {
            _savetimedata = h.GetTotalSeconds() + m.GetTotalSeconds() + s.GetTotalSeconds();
        }

        public override int GetTotalSeconds()
        {
            throw new NotImplementedException();
        }
        public Hours ReturnHours()
        {
            Hours temp = new Hours();
            temp.TimeValue = _savetimedata / 3600;
            return temp;
        }
        public Minutes ReturnMinutes()
        {
            Minutes temp = new Minutes();
            temp.TimeValue = (_savetimedata % 3600) / 60;
            return temp;
        }
        public Seconds ReturnSeconds()
        {
            Seconds temp = new Seconds();
            temp.TimeValue = (_savetimedata % 3600) % 60;
            return temp;
        }
    }
}
