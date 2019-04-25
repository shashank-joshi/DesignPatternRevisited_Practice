using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheTemplateMethod
{
    public abstract class PizzaOrderTemplate
    {
        protected IPizzaTemplate pizzaTemplate;
        public IPizza OrderPizza()
        {
            TakeOrder();
            BakePizza();
            MakePizza();
            ProcessPayment();
            DeliverPizza();
            return pizzaTemplate;
        }

        public virtual string OrderPizza( string Pizza)
        {
            return TakeOrder() +
               BakePizza() +
               MakePizza() +
               ProcessPayment() +
               DeliverPizza();
        }
        public abstract string TakeOrder();
        public abstract string MakePizza();
        public abstract string BakePizza();
        internal string ProcessPayment() => "Processed Payment";


        internal string DeliverPizza() => "Pizza Delivered";
    }
}
