using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public interface IBetterPizza
    {
        int GetNumberOfPizza(string CustomerPhone);
        double GetBillAmount(string CustomerPhone);
        int GetNumberOfOrders();
        int GetNumberOfHomeDeliveredPizza( int dineInPizza);
        string GreetCustomer();

    }
}
