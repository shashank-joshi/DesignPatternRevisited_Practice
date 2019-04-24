using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BasicPizzaBase : IPizzaDecorator
    {
        public int PizzaBase() => 25;
        public double Cost() => 49.25;
    
    }
}
