using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace RealLibrary
{
    internal class Data
    {
        static string _filePath = "../../Data/Books.txt";

        public static List<Books> Load()
        {
            List<Books> listBooks = new List<Books>();
            string[] lines = File.ReadAllLines(_filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                int id = int.Parse(parts[0]);
                string title = parts[1];
                string author = parts[2];
                string year = parts[3];
                string genre = parts[4];
                int count = int.Parse(parts[5]);
                int avbcount= int.Parse(parts[6]);


                listBooks.Add(new Books(id,title,author,year,genre,count,avbcount));
            }

                return listBooks;
        }
      
        public static void Save()
        {
            List<string> lines = new List<string>();
            lines.Add("ID,Title,Author,Year,Genre,Count,AvbCounter");
            foreach (Books book in Books.BookList) 
            {
                string line = book.ToCSVString();
                lines.Add(line);
            }
            File.WriteAllLines(_filePath, lines);
        }
    }
}
