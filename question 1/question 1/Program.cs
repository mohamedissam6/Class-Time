using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(10, 30, 45);
            Time.print12(time);
            Time.print24(time);
            Console.ReadLine();

        }
    }
}
