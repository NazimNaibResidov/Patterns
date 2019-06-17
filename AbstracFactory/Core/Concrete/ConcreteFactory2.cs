using AbstracFactory.Core.Data;
using AbstracFactory.Core.Factory;
using AbstracFactory.Core.Product;

namespace AbstracFactory.Core.Concrete
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
