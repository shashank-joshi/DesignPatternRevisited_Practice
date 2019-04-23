﻿using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    public class SmallPizzaAF : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingrediants)
        {
            return new SmallPizza(ingrediants);
        }
    }
}