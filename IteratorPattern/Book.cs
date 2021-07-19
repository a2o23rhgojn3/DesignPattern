using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Book
    {
        public string Name { get; }
        public Book(string name)
        {
            this.Name = name;
        }
    }
}
