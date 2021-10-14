using System;

namespace _4задание {
    class Program {
        static void Main(string[] args) {
            int a,b;
            Console.WriteLine("Введите первое значение:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение:");
            b = int.Parse(Console.ReadLine());
            a = a + b; 
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первое значение:{a},  Второе значение:{b}");

        }

    }
}
    
  

