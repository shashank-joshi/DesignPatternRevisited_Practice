﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.Core
{
    public class MediumPizza : IPizza
    {
        private IList<string> ingrediants;


        public MediumPizza(IList<string> ingrediants)
        {
            this.ingrediants = ingrediants;
            Console.WriteLine("Medium Pizza with Ingredants: ");
            foreach (var ingrediant in ingrediants)
                Console.WriteLine(ingrediant);
        }

        public MediumPizza() : this(new List<string> { "No " })
        {

        }

        public void Bake()
        {
           
        }

        public void Box()
        {
           
        }

        public void CheckObject(IPizza pizza)
        {
            Console.WriteLine(pizza.GetHashCode());
        }

        public void Cut()
        {
            
        }
        public string OrderPizza() => "Medium Pizza Order";
       
    }
}