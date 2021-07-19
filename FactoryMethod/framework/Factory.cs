using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.framework
{
    abstract class Factory
    {
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
        protected abstract Product CreateProduct(String owner);
        protected abstract void RegisterProduct(Product product);
    }
}
