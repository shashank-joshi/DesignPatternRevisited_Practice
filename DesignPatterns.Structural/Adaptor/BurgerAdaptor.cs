using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adaptor
{
    public class BurgerAdaptor : IFood
    {
        private readonly IBurger burger;
        public BurgerAdaptor(IBurger burger) => this.burger = burger;
        public void Cook() => burger.CookTiki();
        public void Prepare() => burger.Bake();

        public void Serve() => burger.Deliver();
    }
}
