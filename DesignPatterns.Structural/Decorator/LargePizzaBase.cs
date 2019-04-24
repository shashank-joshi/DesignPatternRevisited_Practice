using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class LargePizzaBase:IPizzaDecorator
    {
        IPizzaDecorator _pizzaDecorator;
        public LargePizzaBase() : this(new BasicPizzaBase()) { }
        public LargePizzaBase(IPizzaDecorator pizzaDecorator)
        {
            _pizzaDecorator = pizzaDecorator;
        }
        public int PizzaBase() => _pizzaDecorator.PizzaBase() + 20;
        public double Cost() => _pizzaDecorator.Cost() + 25.50;
    }
}
