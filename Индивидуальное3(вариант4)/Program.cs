using System;

namespace Индивидуальное3 {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("ОДЗ x>0,a>0");
        Console.WriteLine("Введите a ");
        double a = double.Parse(Console.ReadLine());
        if (a>0){
        Console.WriteLine("Введите b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите e ");
        double e = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите x ");
        double x = double.Parse(Console.ReadLine());
        if(x>0){
            double d = a*(Math.Pow(e,- Math.Sqrt(a))) * (Math.Cos(b*x / a));
            Console.WriteLine($"{d}");
            }
            else{
                Console.WriteLine("X Меньше или равен нулю");
            }
            }
            else{
                Console.WriteLine("a Меньше или равен нулю");

            }
        }
    }
}
