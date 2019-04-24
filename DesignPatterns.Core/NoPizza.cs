using System;

namespace DesignPatterns.Core
{
    public class NoPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Nothing");
        }

        public void Box()
        {
            Console.WriteLine("Nothing");
        }

        public void CheckObject(IPizza pizza)
        {
            Console.WriteLine(pizza.GetHashCode());
        }

        public void Cut()
        {
            Console.WriteLine("Nothing");
        }
        public string OrderPizza() => "Leave it; will have something else!!!!";
     

    }
}
