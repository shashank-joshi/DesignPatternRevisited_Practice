﻿using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod
{
    public class SmallPizzaBase : Pizza
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new SmallPizza(toppings);
        }
    }
}