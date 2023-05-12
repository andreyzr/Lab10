using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            Console.Write("Градусы: ");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минуты: ");
            int min_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Секунды: ");
            int sec_ = Convert.ToInt32(Console.ReadLine());
            double s = ToRadians(gradus_, min_,sec_);
            Console.WriteLine(10%360);
            Console.WriteLine(s);
            Console.ReadKey();

        }
        static double ToRadians(int gradus_, int min_, int sec_)
        {
            return  gradus_*(3.14/180) + (min_ / 60) * (3.14 / 180) + (sec_ / 3600) * (3.14 / 180);
        }

    }
}
