using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class UnableToDeside : IOrderPizza
    {
        public string OrderPizza()
        {
            return "Leave it; will have something else!!!!";
        }
    }
}
