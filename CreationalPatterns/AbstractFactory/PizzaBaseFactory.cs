using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public abstract class PizzaBaseFactory
    {
        private IPizzaFactory _pizzaFactory;
        protected PizzaBaseFactory(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }
        public IPizza OrderPizza(IList<string> toppings)
        {
            IPizza pizza = _pizzaFactory.CreatePizza(toppings);

            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
