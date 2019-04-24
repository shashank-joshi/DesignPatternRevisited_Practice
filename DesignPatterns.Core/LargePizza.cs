using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core
{
    public class LargePizza : IPizza
    {
        private IList<string> ingrediants;

        public LargePizza() : this(new List<string> { "No " })
        {

        }
     //   public IPizza _orderPizza { get; set ; }

        public LargePizza(IList<string> ingrediants)
        {
            this.ingrediants = ingrediants;
            Console.WriteLine("Large Pizza with Ingredants: ");
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

        public string OrderPizza() => "Large Pizza Order";
   
    }
}