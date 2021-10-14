using System;
namespace _1задание {
    class Program {
        static void Main (string[] args) {
            double x;
            Console.WriteLine("Введите число с запятой:");
            x = double.Parse(Console.ReadLine()); //присвоение х


            //double x = 27.3198;
            int d = (int)((x - (int)x) * 10); 
            Console.WriteLine("Число после запятой:");
            Console.WriteLine(d); //ответ
            

            

        }
    }
}