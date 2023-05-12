using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner;
            do
            {
                Console.WriteLine("Введите данные");
                Console.Write("Градусы: ");
                int gradus_ = Convert.ToInt32(Console.ReadLine());
                Console.Write("Минуты: ");
                int min_ = Convert.ToInt32(Console.ReadLine());
                Console.Write("Секунды: ");
                int sec_ = Convert.ToInt32(Console.ReadLine());
                corner = new Corner(gradus_, min_, sec_); 
            }
            while (corner.isCorrect == false);



            double totalRadians = corner.ToRadians();
            int gradus = corner.Gradus;
            int min = corner.Min;
            int sec = corner.Sec;

            Console.WriteLine("Градусы равны: {0}°{1}'{2}\"\nПеревод в радианы равен: {3:f2}", gradus, min, sec, totalRadians);
            Console.ReadKey();
        }
    }
}
