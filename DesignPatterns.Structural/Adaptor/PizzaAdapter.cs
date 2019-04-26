using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adaptor
{
    class PizzaAdapter : IFood
    {
        private readonly IPizza pizza;
        public PizzaAdapter(IPizza pizza) => this.pizza = pizza;

        public void Cook() => pizza.Bake();


        public void Prepare() => pizza.Cut(); 


        public void Serve() => pizza.Box();

    }
}
