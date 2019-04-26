using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public interface ITooBadPizzaAPI
    {
        int Method();
        int Execute(int a,int b);
        string DoSomething();
    }
}
