using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Command
{
    public interface IOrderCommand
    {
        StringBuilder sbOrderText { get; set; }
        void PlaceOrder(string order);
        void CancelOrder();
    }
}
