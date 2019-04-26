using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public interface IBadPizzaAPI
    {
        int DoSomething(string data);
        double DoSomethingElse(string somestring);

    }
}
