using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.FactoryMethod
{
    public class SmallPizzaBase : Pizza
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new SmallPizza(toppings);
        }
    }
}
