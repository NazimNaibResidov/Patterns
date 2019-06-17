using AbstracFactory.Core.Product;
using System;

namespace AbstracFactory.Core.Data
{
    public class ProductB1: AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
            " interacts with " + a.GetType().Name);
        }
    }
}
