using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.FactoryMethod
{
    public class LargPizzaBase : Pizza
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new LargePizza(toppings);
        }
    }
}
