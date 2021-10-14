using System;

namespace _5задание {
    class Program {
        static void Main(string[] args) {
            int a,b,d;
            double c;
            Console.WriteLine("Введите первый катет:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет:");
            b = int.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow( b, 2)) + (a + b); //периметр
            d = (a * b) / 2; // площадь
            Console.WriteLine($"Периметр:{c} Площадь:{d}");





            
        }
    }
}
