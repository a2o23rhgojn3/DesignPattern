using FactoryMethod.framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.idcard
{
    class IDCardFactory: Factory
    {
        public ArrayList owners { get; } = new ArrayList();
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }
        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product).owner);
        }
    }
}
