using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class TooBadPizza : ITooBadPizzaAPI
    {
        public string DoSomething() => "Welcome Sir";

        public int Execute(int a, int b) => Method() - b;


        public int Method() => 134;
        
    }
}
