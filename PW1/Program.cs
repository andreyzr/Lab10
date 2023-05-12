using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Clock clock;
            do
            {
                Console.WriteLine("Введите данные");
                int hour_ = Convert.ToInt32(Console.ReadLine());
                int minute_ = Convert.ToInt32(Console.ReadLine());
                int second_ = Convert.ToInt32(Console.ReadLine());

                clock = new Clock(hour_, minute_, second_);  //Третий способ-создание своего конструктора
            }
            while (clock.isCorrect == false);
            //Clock clock = new Clock() { hour=hour_,minute=minute_,second=second_}; Второй способ-через конструктор

            //clock.hour =Convert.ToInt32(Console.ReadLine());  Первый способ-прямое присваивание
            //clock.minute =Convert.ToInt32(Console.ReadLine());
            //clock.second =Convert.ToInt32(Console.ReadLine());


            int totalSecond = clock.ToSecond();
            Console.WriteLine(totalSecond);
            Console.ReadKey();
        }
    }
}
