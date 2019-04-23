using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public class CustomPizzaFactory : PizzaBaseFactory
    {
        protected CustomPizzaFactory() : this(new CustomPizzaAF())
        {

        }
        public CustomPizzaFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }
    }
}
