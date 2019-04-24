using DesignPatterns.Core;
using System.Collections.Generic;

namespace CreationalPatterns.FactoryMethod
{
    public abstract class Pizza
    {
      
        public IPizza OrderPizza(IList<string> toppings)
        {
            IPizza pizza = CreatePizza(toppings);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
                     
        public abstract IPizza CreatePizza(IList<string> toppings);
      
    }
}
