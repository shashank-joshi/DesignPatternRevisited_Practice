using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public class SmallPizzaAF : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingrediants)
        {
            return new SmallPizza(ingrediants);
        }
    }
}
