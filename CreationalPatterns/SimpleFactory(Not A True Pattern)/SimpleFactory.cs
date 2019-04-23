using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.SimpleFactory_Not_A_True_Pattern_
{
    public enum PizzaType {
        Large,
        Medium,
        Small
    }
    public static class SimpleFactory
    {
        public static IPizza pizza;
        public static IPizza CreatePizza(PizzaType pizzaType, IList<string> ingrediants)
        {
            
            switch (pizzaType)
            {
                case PizzaType.Large:
                    pizza = new LargePizza(ingrediants);
                    return pizza;
                case PizzaType.Medium:
                    pizza = new MediumPizza(ingrediants);
                    return pizza;
                case PizzaType.Small:

                    pizza =  new SmallPizza(ingrediants);
                    return pizza;
                default:
                    return null;
            }
        }
    }
}
