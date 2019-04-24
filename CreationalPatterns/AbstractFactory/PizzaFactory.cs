using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingrediants);
    }
}
