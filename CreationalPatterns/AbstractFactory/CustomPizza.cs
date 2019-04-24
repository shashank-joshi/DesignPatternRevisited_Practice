using DesignPatterns.Core;
using System;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory
{
    public class CustomPizza : IPizza
    {
        public IPizza _orderPizza { get; set; }
        public IList<string> Toppings { get; }

        public void Bake()
        {
            Console.WriteLine("Custom Pizza Baked ");
        }

        public void Box()
        {
            Console.WriteLine("Custom Pizza Box Packed");
        }

        public void Cut()
        {
            Console.WriteLine("Custom Pizza Cutted");
        }

        public void CheckObject(IPizza pizza)
        {
            
        }

        public string OrderPizza() => "Custom Pizza Order";

        public void ChangeOrder(IPizza pizza)
        {
            _orderPizza = pizza;
        }

        public CustomPizza(IList<string> toppings)
        {
            Toppings = toppings;
            Console.WriteLine("Custom Pizza with Ingredants: ");
            foreach (var ingrediant in toppings)
                Console.WriteLine(ingrediant);
        }
    }
}
