using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealLibrary
{
    
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Books.BookList = Data.Load();

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("===============");
                Console.WriteLine("Избери опция:");
                Console.WriteLine("===============");
                Console.WriteLine("1 - Добива книга ");
                Console.WriteLine("2 - Наеми книга ");
                Console.WriteLine("3 - Покажи всички книги");
                Console.WriteLine("4 - Филтрирай и покажи всички вкиги");
                Console.WriteLine("5 - Излез");
                Console.Write("въведи число: ");
                
                int option = int.Parse(Console.ReadLine());   

                switch (option)
                {
                    case 1: Books.AddBook(); break;

                    case 2: Books.RentBook(); break;

                    case 3: Books.ShowBooks();break;

                    case 4: Books.PrintBooksBy(); break;

                    case 5: return;  

                }
                Console.ReadLine();


                Data.Save();

            }

            

        }
    }
}
