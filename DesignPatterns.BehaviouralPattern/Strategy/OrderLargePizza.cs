using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class OrderLargePizza : IOrderPizza
    {
        public string OrderPizza() => "Large Pizza Order";
      
    }
}
