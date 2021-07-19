using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は一緒のインスタンスです");
            }
            else
            {
                Console.WriteLine("一緒のインスタンスではありません");
            }
            Console.WriteLine("END");

        }
    }
}
