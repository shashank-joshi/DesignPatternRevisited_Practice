using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    class PizzaFacade : IBetterPizza
    {
        private readonly IBadPizzaAPI badPizzaAPI;
        private readonly ITooBadPizzaAPI tooBadPizzaAPI;

        public PizzaFacade()
        {
            badPizzaAPI = new BadPizza();
            tooBadPizzaAPI = new TooBadPizza();
        }
        public PizzaFacade(IBadPizzaAPI badPizzaAPI, ITooBadPizzaAPI tooBadPizzaAPI)
        {
            this.badPizzaAPI = badPizzaAPI;
            this.tooBadPizzaAPI = tooBadPizzaAPI;
        }
        public double GetBillAmount(string CustomerPhone) => badPizzaAPI.DoSomethingElse(CustomerPhone);

        public int GetNumberOfHomeDeliveredPizza(int dineInPizza) => tooBadPizzaAPI.Execute(GetNumberOfOrders(), dineInPizza);

        public int GetNumberOfOrders() => tooBadPizzaAPI.Method();

        public int GetNumberOfPizza(string CustomerPhone) => badPizzaAPI.DoSomething(CustomerPhone);

        public string GreetCustomer() => tooBadPizzaAPI.DoSomething();
    }
}
