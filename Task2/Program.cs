using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка","черный",-1);
            cat.Say();
            Console.ReadKey();

        }
    }
    class Cat
    {
         public string Name { get; set; }
         public string Color { get; set; }
         int age;

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age=value;
                }
                else
                {
                    Console.WriteLine("Возрасто не должен быть меньше нуля");
                }
            }
            get { return age; }

        }
        public Cat(string name,string color, int age ) 
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public void Say()
        {
            Console.WriteLine("Мяу.Меня зовут {0}.У меня {1} черный цвет. Мне {2} лет", Name,Color,Age);
        }
    }
}
