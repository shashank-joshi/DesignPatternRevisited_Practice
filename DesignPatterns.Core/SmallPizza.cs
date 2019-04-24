using System;
using System.Collections.Generic;

namespace DesignPatterns.Core
{
    public class SmallPizza : IPizza
    {
        private IList<string> ingrediants;
        public SmallPizza():this(new List<string> { "No "})
        {

        }
        public SmallPizza(IList<string> ingrediants)
        {
            this.ingrediants = ingrediants;
            Console.WriteLine("Small Pizza with Ingredants: ");
            foreach (var ingrediant in ingrediants)
                Console.WriteLine(ingrediant);
        }

        public void Bake()
        {
            
        }

        public void Box()
        {
           
        }

        public void CheckObject(IPizza pizza)
        {
            Console.WriteLine(pizza.GetHashCode());
        }

        public void Cut()
        {
            
        }

     

        public string OrderPizza() => "Small Pizza Order";
    }
}