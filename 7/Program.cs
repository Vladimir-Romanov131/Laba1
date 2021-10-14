using System;

namespace _7задание {
    class Program {
        static void Main(string[] args) {
            int a;
            string b;
            Console.WriteLine("Введите трехзначное число:");
            a = int.Parse(Console.ReadLine());
            b = a.ToString();
            

            char[] inputarray = b.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            System.Console.WriteLine( output);

         
        }
    }
}
