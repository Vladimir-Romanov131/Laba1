using System;
namespace _3задание {
    class Program {
        static void Main(string[] args) {
            int a, b, c;
            Console.WriteLine("Задайте значения часа:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значения минут:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значения секунд:");
            c = int.Parse(Console.ReadLine());
            int z = (a * 30); // градус часа
            int x = (b * 2 ); // градус минуты 
            double v = (c * 0.03  ); // градус секунды 
            double q = (z + x + v);
            
            Console.WriteLine($" Градус:{q}");
            

        }
    }
}