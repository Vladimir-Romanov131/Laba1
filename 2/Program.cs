using System;
namespace _2задание {
    class Program {
        static void Main(string[] args) {
            long a,b,c,d;
        
            Console.WriteLine("Введите секунды:");
            a = long.Parse(Console.ReadLine()); //секунды 
            c = a / 3600;
            b = (a - ( c * 3600)) / 60;
            d = (a - (c * 3600) - (b * 60));

             // часы
            //d = c / 24; // сутки 
           // g = d / 365; //года
            //j = ((a / 60) - b) * 100; 






            Console.WriteLine($"Часов:{c} Минут:{b} Секунды: {d} " );

        }
    }
}
