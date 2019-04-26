using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adaptor
{
    public class TikkiBurger : IBurger
    {
        public void Bake() => Console.WriteLine("Baked the Tikki Burger");


        public void CookTiki() => Console.WriteLine("Tikki Cooked");


        public void Deliver() => Console.WriteLine("Delivered to Customer");
        
    }
}
