using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    class LargePizzaFactory : PizzaBaseFactory
    {
        protected LargePizzaFactory() : this(new LargePizzaAF()) { }
        public LargePizzaFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }
    }
}
