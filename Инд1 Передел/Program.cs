using System;
using System.Collections;
namespace HelloApp {
    public class baza {
        public enum genre{
            X,Y,C

        }
        

        public class Country {

        public String name;
        public String title;
        public int year;
        public genre  Countrygenre;
        public Country(string name,string title,int year, genre Countrygenre){
            this.name = name;
            this.title = title;
            this.year = year;
            this.Countrygenre = genre;
        }
        public void Print(){
            Console.WriteLine($"|{$"{this.name}",-15}|{$"{this.title}",-20}|{$"{this.year}",-20}|{$"{this.Countrygenre}", -6}| "); 
        }     
    }
    
        static void Main() {
            ArrayList list = new();      
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Автор:");
                string name = Console.ReadLine();

                 genre Countrygenre ;
                while (true)
                {
                    Console.WriteLine("Жанры(X,Y,C):");
                    string tmp = Console.ReadLine();
                    if (tmp == "X")
                    {
                        Countrygenre = genre.X;
                        break;
                    }
                    else if (tmp == "Y")
                    {
                        Countrygenre = genre.Y;
                        break;
                    }
                    if (tmp == "C")
                    {
                        Countrygenre = genre.C;
                        break;
                    }
                    else Console.WriteLine("Некорректный ввод значения. Введите еще раз.");

                }
                Console.WriteLine("Год создания:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Название:");
                string title = Console.ReadLine();
                Country value = new(name, title, year, Countrygenre);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Каталог Библиотеки",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Автор",-25}|{"Название",-12}|{"Год создания",-20}|{"Жанр",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Country item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: F – федерация, US - унитарное гос-во",-75}|");
            Console.WriteLine(new String('-', 76));}

        }
    }
}
    
            
            
        

    
    