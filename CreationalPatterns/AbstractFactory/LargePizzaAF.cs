using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public class LargePizzaAF : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingrediants)
        {
            return new LargePizza(ingrediants);
        }
    }
}
