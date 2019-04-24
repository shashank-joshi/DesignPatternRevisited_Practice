using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class LargePizzaStrategy:PizzaStrategy
    {
        public LargePizzaStrategy() : base(new LargePizza()) { }
    }
}
