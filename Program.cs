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

            Books.BookList = Data.Load();
        }
    }
}
