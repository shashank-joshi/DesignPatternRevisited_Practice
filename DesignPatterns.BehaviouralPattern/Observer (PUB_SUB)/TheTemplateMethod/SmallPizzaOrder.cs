using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheTemplateMethod
{
    public class SmallPizzaOrder : PizzaOrderTemplate
    {
        public override string BakePizza() => "Baking Small Pizza ";


        public override string MakePizza() => "Making Small Pizza";


        public override string TakeOrder() => "Ordered Small Pizza";
       
    }
}
