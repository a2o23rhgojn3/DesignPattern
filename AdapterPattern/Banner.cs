using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Banner
    {
        private String _string;
        public Banner(string str)
        {
            this._string = str;
        }
        public void ShowWithParen()
        {
            Console.WriteLine($"({_string})");
        }
        public void ShowWithAster()
        {
            Console.WriteLine($"*{_string}*");
        }
    }
}
