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
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public int Count { get; set; }
        public int AvbCounter { get; set; }
        public static List<Books> BookList = new List<Books>();
        public static List<Books> ViewBooks = new List<Books>();

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
             Console.WriteLine(" Напиши следните данни за книгата отделени с запетайки:  ");
             Console.WriteLine("Заглавие на книгата, Автор, Година на издаване, Жанр, Брой копия от книгата");

             string newBook = Console.ReadLine();
             string[] newBookData = newBook.Split(',') ;

             int a = new Random().Next(0, 10000000) ;
           
             
 
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
            string csvInfo = $" title {Title}, author {Author}, Year {Year}, Genre {Genre},Count {Count},AvbCounter {AvbCounter} ";
            
            return csvInfo;
        }
        public static void ShowBooks()
        {
            //ListForViewers();
            Console.WriteLine("\n======== Books ==========");
           

          
            foreach (Books book in BookList)
            {
                Console.WriteLine(book.Info());
               
            }
        }

      // public static void ListForViewers() //nachi ideqta mi e da ima list kojto pri razpechatvane da pokazva samo zaglavie,avtor,godina,janr,count,avbCounter                                  
       // {                                           //bez da pokazva vsqka kniga s razlicno id a samo kolko broq ima ot dadena kniga
                                                    //inache informaciqta she da vadim ot drugiq spisak ,naprimer kato vzimash kniga

            // List<Books> viewBooks =new List<Books>(); //- tova e public static,da ne se chudish kade e ,gore e :D

          //  ViewBooks.Clear();
          //  for (int i = 1; i < BookList.Count; i++) 
          //  {
                
                
                //    if (BookList[i].Title == BookList[i-1].Title && BookList[i].Author == BookList[i - 1].Author
                        // && BookList[i].Year == BookList[i - 1].Year && BookList[i].Genre == BookList[i - 1].Genre)
                //    {
                   //     continue;
                   // }
              //  if (BookList[i] == null) { ViewBooks.Add(BookList[i]);continue; }
                  //  ViewBooks.Add(BookList[i]);
                
           // }
       // }

     

        public static void PrintBooksBy () //niga tui ne backa
        {
            //ListForViewers();

            Console.WriteLine("Сортирай книгите според:");
            Console.WriteLine("1 - заглавие");
            Console.WriteLine("2 - автор");
            Console.WriteLine("3 - година");
            Console.WriteLine("4 - жанр ");
            int i = int.Parse(Console.ReadLine());

            if (i == 1) 
            {
                Console.WriteLine( "Въведете заглавие според което искате да филтрирате книгите:" );
                string wantedTitle = Console.ReadLine();
                foreach (Books book in ViewBooks) 
                {
                    if (book.Title == wantedTitle)
                       
                    {
                        Console.WriteLine($"{book.Title}{book.Author} {book.Year} {book.Genre} Бройки:{book.Count} Налични бройки:{book.AvbCounter}");
                    }
                }
            
            }

            if (i == 2)
            {
                Console.WriteLine("Въведете автор според който искате да филтрирате книгите:");
                string wantedAuthor = Console.ReadLine();
                foreach (Books book in ViewBooks)
                {
                    if (book.Author == wantedAuthor)

                    {
                        Console.WriteLine($"{book.Title}{book.Author} {book.Year} {book.Genre} Бройки:{book.Count} Налични бройки:{book.AvbCounter}");
                    }
                }

            }

            if (i == 3)
            {
                Console.WriteLine("Въведете година според която искате да филтрирате книгите:");
                string wantedYear = Console.ReadLine();
                foreach (Books book in ViewBooks)
                {
                    if (book.Year == wantedYear)

                    {
                        Console.WriteLine($"{book.Title}{book.Author} {book.Year} {book.Genre} Бройки:{book.Count} Налични бройки:{book.AvbCounter}");
                    }
                }

            }

            if (i == 4)
            {
                Console.WriteLine("Въведете жанр според който искате да филтрирате книгите:");
                string wantedGenre = Console.ReadLine();
                foreach (Books book in ViewBooks)
                {
                    if (book.Genre == wantedGenre)

                    {
                        Console.WriteLine($"{book.Title}{book.Author} {book.Year} {book.Genre} Бройки:{book.Count} Налични бройки:{book.AvbCounter}");
                    }
                }

            }
        }
        public static void RentBook()
        {
            Console.WriteLine("За наемане 1, за преглед на книгите 2 ");
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1: Console.WriteLine("Избери книга");
                    string wantedbook = Console.ReadLine();
                    foreach (Books book in BookList)//ne backa 
                    {
                        if (book.Title == wantedbook)
                        {
                            Console.WriteLine("Взехте книгата");
                            book.AvbCounter--;
                        }
                    }
                    break;
                case 2: Books.ShowBooks(); break;
            }
        }

    }
}
