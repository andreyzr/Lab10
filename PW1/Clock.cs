using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1
{
    class Clock
    {
        int hour;
        int minute;
        int second;
        public bool isCorrect = true;

        public int Hour //Свойство
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    hour = value % 24;
            }
        }

        public int Minute //Свойство
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Hour += value / 60;
                    minute = value % 60;
                }

            }
        }

        public int Second //Свойство
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Minute += value / 60;
                    second = value % 60;
                }

            }
        }


        public Clock(int hour, int minute, int second) //Третий способ-создание своего конструктора
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public int ToSecond()//Метод
        {
            return second + minute * 60 + hour * 60 * 60;
        }
    }

}
