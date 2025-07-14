using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RealLibrary
{
    internal class Books
    {
        public int Id {  get; set; } //efeeg
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public int Count { get; set; }
        public int AvbCounter { get; set; }
        public static List<Books> BookList = new List<Books>();
        //public static List<Books> ViewBooks = new List<Books>();

        public Books(int id, string title, string author, string year, string genre, int count, int avbCounter)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            Count = count;
            AvbCounter = avbCounter;
        }
            public static void AddBook()
             { 
             Console.WriteLine("Напиши следните данни за книгата отделени с запетайки:  ");
             Console.WriteLine("Заглавие на книгата, Автор, Година на издаване, Жанр, Брой копия от книгата");

             string newBook = Console.ReadLine();
             string[] newBookData = newBook.Split(',') ;

             int a = new Random().Next(0, 1000000) ;
           
             
 
              while ( true)
              {
               
                    Books book = new Books(0,null,null,null,null,0,0);
                   

                    book.Id = a;
                    book.Title = newBookData[0];
                    book.Author = newBookData[1];
                    book.Year = newBookData[2];
                    book.Genre = newBookData[3];
                    book.Count = int.Parse(newBookData[4]);
                    book.AvbCounter = int.Parse(newBookData[4]);  
                    
                    BookList.Add(book);
                Console.WriteLine("Добавихте нова книга!");
                return;
                
            }
              
            }
        public string ToCSVString()
        {
            string csvInfo = $"{Id},{Title},{Author},{Year},{Genre},{Count},{AvbCounter}";

            return csvInfo;
        }
        public string Info()
        {
           
            string csvInfo = $" Заглавие: {Title,-35} Автор: {Author,-20} {Year,10} г. Жанр: {Genre,-20}Обща бройка: {Count,-7}Налична бройка: {AvbCounter,-8}";
            
            return csvInfo;
        }
        public static void ShowBooks()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n========================================================================= Books =========================================================================");
           
          
            foreach (Books book in BookList)
            {
                Console.WriteLine(book.Info());
               
            }
        }


        public static void PrintBooksBy () 
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("========================");
            Console.WriteLine("Сортирай книгите според:");
            Console.WriteLine("1 - заглавие");
            Console.WriteLine("2 - автор");
            Console.WriteLine("3 - година");
            Console.WriteLine("4 - жанр ");
            Console.WriteLine("========================");
            Console.ResetColor();
            Console.Write("Въведи число: ");
            Console.ForegroundColor= ConsoleColor.Red;
            int i = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;

            if (i == 1) 
            {
                bool b = false;
                Console.WriteLine( "Въведете заглавие според което искате да филтрирате книгите:" );
                Console.ForegroundColor = ConsoleColor.Red;
                string wantedTitle = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (Books book in BookList) 
                {
                    
                    if (book.Title == wantedTitle)
                       
                    {
                        Console.WriteLine($" Заглавие: {book.Title,-35} Автор: {book.Author,-20} {book.Year,10} г. Жанр: " +
                            $"{book.Genre,-20}Обща бройка: {book.Count,-7}Налична бройка: {book.AvbCounter,-8}");
                        b= true;
                    }
                }
                if(b ==false) 
                {
                    Console.WriteLine("Няма намерени книги с това заглавие");
                }
               
            }

            if (i == 2)
            {
                bool b = false;
                Console.WriteLine("Въведете автор според който искате да филтрирате книгите:");
                Console.ForegroundColor = ConsoleColor.Red;
                string wantedAuthor = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                foreach (Books book in BookList)
                {
                    if (book.Author == wantedAuthor)

                    {
                        Console.WriteLine($" Заглавие: {book.Title,-35} Автор: {book.Author,-20} {book.Year,10} г. Жанр: " +
                             $"{book.Genre,-20}Обща бройка: {book.Count,-7}Налична бройка: {book.AvbCounter,-8}");
                        b = true;
                    }
                }
                if (b == false)
                {
                    Console.WriteLine("Няма намерени книги с този автор");
                }
            }

            if (i == 3)
            {
                bool b = false;
                Console.WriteLine("Въведете година според която искате да филтрирате книгите:");
                Console.ForegroundColor = ConsoleColor.Red;
                string wantedYear = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                foreach (Books book in BookList)
                {
                    if (book.Year == wantedYear)

                    {
                        Console.WriteLine($" Заглавие: {book.Title,-35} Автор: {book.Author,-20} {book.Year,10} г. Жанр: " +
                             $"{book.Genre,-20}Обща бройка: {book.Count,-7}Налична бройка: {book.AvbCounter,-8}");
                        b = true;
                    }
                }
                if (b == false)
                {
                    Console.WriteLine("Няма намерени книги с тази година");
                }
                
            }

            if (i == 4)
            {
                bool b = false;
                Console.WriteLine("Въведете жанр според който искате да филтрирате книгите:");
                Console.ForegroundColor = ConsoleColor.Red;
                string wantedGenre = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                foreach (Books book in BookList)
                {
                    if (book.Genre == wantedGenre)

                    {
                        Console.WriteLine($"Заглавие: {book.Title,-35} Автор: {book.Author,-20} {book.Year,10} г. Жанр: " +
                             $"{book.Genre,-20}Обща бройка: {book.Count,-7}Налична бройка: {book.AvbCounter,-8}");
                        b = true;
                    }
                    
                }
                if (b == false)
                {
                    Console.WriteLine("Няма намерени книги с този жанр");
                }
            }
        }
        public static void RentAndReturnBook()
        {
            Console.WriteLine("За наемане 1, за връщане на книга 2, за преглед на книгите 3 , ");
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1: Console.WriteLine("Избери книга");
                    string wantedbook = Console.ReadLine();
                    foreach (Books book in BookList)
                    {
                        if (book.AvbCounter <= book.Count && book.AvbCounter > 0)
                        {
                            if (book.Title == wantedbook)
                            {
                                Console.WriteLine("Наехте книгата");
                                book.AvbCounter--;
                                return;
                            }
   
                        }

                    }

                    Console.WriteLine("няма наличие на тази книга в момента");
                    break;

                case 2:
                    Console.WriteLine("Коя книга връщаш?");
                    string returnedbook = Console.ReadLine();
                    foreach (Books book in BookList)  
                    {
                        if (book.AvbCounter < book.Count)
                        {
                            if (book.Title == returnedbook)
                            {
                                Console.WriteLine("Върнахте книгата");
                                book.AvbCounter++;
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Няма данни за наета такава книга"); break;

                case 3: Books.ShowBooks(); break;
            }
        }

    }
}
