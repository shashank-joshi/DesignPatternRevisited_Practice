using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.FactoryMethod
{
    public class MediumPizzaBase : Pizza
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new MediumPizza(toppings);
        }
    }
}
