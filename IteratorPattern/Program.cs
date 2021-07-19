using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("around the world in 80 days"));
            bookShelf.AppendBook(new Book("alian"));
            bookShelf.AppendBook(new Book("math"));
            bookShelf.AppendBook(new Book("magic dragon"));
            IIterator it = bookShelf.iterator();
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.Name);
            }
            Console.WriteLine("何か入力してください");
            Console.ReadKey();
        }
    }
}
