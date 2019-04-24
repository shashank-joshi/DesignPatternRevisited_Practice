using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public class MediumPizzaAF : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingrediants)
        {
            return new MediumPizza(ingrediants);
        }
    }
}
