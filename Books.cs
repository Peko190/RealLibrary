using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
            public void AddBook()
             { 
             Console.WriteLine(" Напиши следните данни за книгата отделени с запетайки:  ");
             Console.WriteLine("Заглавие на книгата, Автор, Година на издаване, Жанр, Брой копия от книгата");

             string newBook = Console.ReadLine();
             string[] newBookData = newBook.Split(',') ;
             int counter = int.Parse(newBookData[4]);
 
              while (counter > 0)
              {
                for (int i = 0; i < newBookData.Length; i++)
                {
                    
                    Books book = new Books(0,null,null,null,null,0,0);
                    book.Title = newBookData[0];
                    book.Author = newBookData[1];
                    book.Year = newBookData[2];
                    book.Genre = newBookData[3];
                    book.Count = counter;
                    counter--;
                    BookList.Add(book);
                }
              }
            }

        /* public static void PrintBooks()
        {
            if (BookList.Count <= 0)
            {
                Console.WriteLine("Няма добавени книги.");
                return;
            }

            foreach (var b in BookList)
            {
                Console.WriteLine($" {b.Title},  {b.Author}, {b.Year},  {b.Genre},  {b.Count}");
            }
        }
        */

    }
}
