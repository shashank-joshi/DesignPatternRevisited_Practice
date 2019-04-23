using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingrediants);
    }
}
