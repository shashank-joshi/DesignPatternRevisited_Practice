using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    class MediumPizzaaFActory : PizzaBaseFactory
    {
        protected MediumPizzaaFActory() : this(new MediumPizzaAF()) {
        }
        public MediumPizzaaFActory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }
    }
}
