using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "черный", 1);
            cat.name = "Мурка";
            cat.color = "Черный";
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.color);
            Console.ReadKey();

        }
    }
    class Cat
    {
        public string name;
        public string color;
        public int age;
        public Cat(string name, string color = "Серый", int age = 1)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        public void Say()
        {
            Console.WriteLine("Мяу.Меня зовут {0}",name);
        }
    }
}
