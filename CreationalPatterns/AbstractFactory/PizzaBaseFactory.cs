using DesignPatterns.Core;
using System.Collections.Generic;

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
