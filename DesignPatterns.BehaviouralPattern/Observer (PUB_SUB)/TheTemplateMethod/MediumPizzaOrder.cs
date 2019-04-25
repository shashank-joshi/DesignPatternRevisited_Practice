using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheTemplateMethod
{
    public class MediumPizzaOrder : PizzaOrderTemplate
    {
        public override string OrderPizza(string Pizza)
        {
            return TakeOrder()+
            BakePizza()+
            MakePizza()+
            DeliverPizza()+
            ProcessPayment();
          
        }
        public override string BakePizza() => "Baking Medium Pizza ";


        public override string MakePizza() => "Making Medium Pizza";


        public override string TakeOrder() => "Ordered Medium Pizza";
    }
}
