using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public class ThePizzaFactory : PizzaBaseFactory
    {
        protected ThePizzaFactory():this(new SmallPizzaAF()){ }
        public ThePizzaFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }
    }
}
