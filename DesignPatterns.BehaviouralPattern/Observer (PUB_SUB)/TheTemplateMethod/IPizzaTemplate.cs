using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheTemplateMethod
{
    public interface IPizzaTemplate:IPizza
    {
        PizzaBase pizzaBase { get; set; }
    }
}
