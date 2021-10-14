using System;

namespace Индивидуальное2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ОДЗ x>0,a>0");
            Console.WriteLine("Введите a ");
            double a = double.Parse(Console.ReadLine());
            if (a>0){
            Console.WriteLine("Введите b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x ");
            double x = double.Parse(Console.ReadLine());
            if(x>0){
                double x1;
                x1 = x;
                Math.Pow(x1,2);
                double y = a*b*x1 - (a / Math.Pow(Math.Sin(x/a),2));
                Console.WriteLine($"{y}");

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
