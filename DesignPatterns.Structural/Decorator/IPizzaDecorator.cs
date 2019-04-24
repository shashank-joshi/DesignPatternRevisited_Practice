using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public interface IPizzaDecorator
    {
        int PizzaBase();
        double Cost();
    }
}
