using System;

namespace _6задание {
    class Program {
        static void Main(string[] args) {
            int a, o;
            Console.WriteLine("Введите четырехзначное число:");
            a = int.Parse(Console.ReadLine());
            int q = a / 1000; // (1) 538
            int w = (a - q * 1000) / 100; //1(5)38
            int e = (a - q * 1000 - w * 100) / 10; //15(3)8
            int r = (a - q * 1000 - w * 100 - e * 10); //153(8)
            o = (q*w*e*r); //1*5*3*8
            Console.WriteLine($"Ответ:{o}"); //120


        }
    }
}
