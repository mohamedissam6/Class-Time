using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    internal class Time
    {
        public int hour;
        public int minute;
        public int second;

        public Time()
        {
            Time time = new Time();
        }

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public static void print12(Time time)
        {
            int x = time.hour;
            if (time.hour > 12) { 
                x-=12;
            Console.WriteLine("{0} : {1} : {2} PM",x,time.minute,time.second);
        }
            else
            {
            Console.WriteLine("{0} : {1} : {2} AM", x, time.minute, time.second);
            }
        }

        public static void print24(Time time)
        {
            Console.WriteLine("{0} : {1} : {2} ",time.hour,time.minute,time.second); 
        }

    }
}
