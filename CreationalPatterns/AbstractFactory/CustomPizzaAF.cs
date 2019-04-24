using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public class CustomPizzaAF : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingrediants)
        {
            return new CustomPizza(ingrediants);
        }
    }
}
