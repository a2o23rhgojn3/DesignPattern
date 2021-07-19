using FactoryMethod.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.idcard
{
    class IDCard: Product
    {
        public string owner { get; }
        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作成します");
            this.owner = owner;
        }
        public override void Use()
        {
            Console.WriteLine($"{owner}のカードを使います");
        }
    }
}
