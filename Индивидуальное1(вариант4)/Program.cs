using System;

namespace Индивидуальное1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\tАвтор\t\tНазвание\tГод выпуска\tЖанр");

            
            // Console.WriteLine("\t{x1}\t\t{y1}\t\t{c1}\t\t{d1}");
            // Console.WriteLine("\t{0}\t\t{1}\t\t{3}\t\t{4}");
            // Console.WriteLine("\t{0}\t\t{1}\t\t{3}\t\t{4}");
            // Console.WriteLine("\t{0}\t\t{1}\t\t{3}\t\t{4}");
            // Console.WriteLine("\t{0}\t\t{1}\t\t{3}\t\t{4}");
            // Console.WriteLine("\t{0}\t\t{1}\t\t{3}\t\t{4}");
            

            
            Console.WriteLine("Введите данные книги");
            Console.WriteLine("Автор книги");
            string x1 = Console.ReadLine();
            Console.WriteLine("Название");
            string y1 = Console.ReadLine();
            Console.WriteLine("Год выпуска");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Жанр");
            char d1 = char.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите данные книги");

            Console.WriteLine("Автор книги");
            string x2 = Console.ReadLine();
            Console.WriteLine("Название");
            string y2 = Console.ReadLine();
            Console.WriteLine("Год выпуска");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Жанр");
            char d2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите данные книги");
            Console.WriteLine("Автор книги");
            string x3 = Console.ReadLine();
            Console.WriteLine("Название");
            string y3 = Console.ReadLine();
            Console.WriteLine("Год выпуска");
            int c3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Жанр");
            char d3 = char.Parse(Console.ReadLine());
            Console.WriteLine("Каталог Библиотеки");

            Console.WriteLine("\tАвтор\t\tНазвание\tГод выпуска\t\tЖанр");
            Console.WriteLine($"1.\t{x1}\t\t{y1}\t\t{c1}\t\t\t{d1}");
            Console.WriteLine($"2.\t{x2}\t\t{y2}\t\t{c2}\t\t\t{d2}");
            Console.WriteLine($"3.\t{x3}\t\t{y3}\t\t{c3}\t\t\t{d3}");
            


            
            

            // Console.WriteLine($"1. {r1}");
            // Console.WriteLine($"2. {r2}");
            // Console.WriteLine($"3. {r3}");
            





        
        }
    }
}
