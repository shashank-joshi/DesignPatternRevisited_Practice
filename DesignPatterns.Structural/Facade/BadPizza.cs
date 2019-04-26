using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class BadPizza : IBadPizzaAPI
    {
        public int DoSomething(string data) => 3;

        public double DoSomethingElse(string somestring) => 255.0;
    }
}
