using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
