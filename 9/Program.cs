using System;

namespace _9задание {
    class Program {
        static void Main(string[] args) {
            float a1,b1,c1,d1;
            float a2,b2,c2,d2;
            float a3,b3,c3,d3;
            float x,y,z,ay,ad,az,ax;
            Console.WriteLine("Введите a,b,c,d для первого уравнения, для d число больше 0");
            a1 = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a,b,c,d для второго уравнения, для d число больше 0");
            a2 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a,b,c,d для третьего уравнения, для d число больше 0");
            a3 = int.Parse(Console.ReadLine());
            b3 = int.Parse(Console.ReadLine());
            c3 = int.Parse(Console.ReadLine());
            d3 = int.Parse(Console.ReadLine()); 
            
    
            ax = a1 * b1 / c1;
            ay = a2 * a1 / a1;
            az = c1 * a2 / a1;
            ad = d1 * a2 / a1;
            a2 = a2 - ax;
            b2 = b2 - ay;
            c2 = c2 - az;
            d2 = d2 - ad;
            ax = a1 * a3 / a1;
            ay = b1 * a3 / a1;
            az = c1 * a3 / a1;
            ad = d1 * a3 / a1;
            a3 = a1 - ax;
            b3 = b3 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            ay = b2 * b3 / b3;
            az = c2 * b3 / b2;
            ad = c2 * b3 / b2;
            b2 = b2 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            z = d3 / c3;
            y = (c2 - b2 * z) / b2;
            x = (d1 - c1 * z - b1 * y) / a1;
            Console.WriteLine($" Ответ:x={x};y={y};z={z}");

        }
    }
}
