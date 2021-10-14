using System;

namespace _8задание {
    class Program {
        static void Main(string[] args) {
            double x4,x2,x3,x,y;
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());
            x4 = x;
            x3 = x;
            x2 = x;
            Math.Pow(x4,4);
            Math.Pow(x3,3);
            Math.Pow(x2,2);
            y = (((3 * x4 -  5) * x3 +  2) * x2 - 1) * x + 7;
            Console.WriteLine($"Ответ:{y}");
        }
    }
}
