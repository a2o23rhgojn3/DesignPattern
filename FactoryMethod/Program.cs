using FactoryMethod.framework;
using FactoryMethod.idcard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("佐藤");
            Product card2 = factory.Create("ダニエル");
            Product card3 = factory.Create("ユチョン");
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
