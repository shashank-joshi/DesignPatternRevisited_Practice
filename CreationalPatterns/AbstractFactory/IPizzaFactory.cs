using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> ingrediants);
    }
}
