using DesignPatterns.Core;
using System;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class PizzaStrategy : IOrder
    {
        private IOrderPizza _orderPizza;
        public PizzaStrategy() : this(new UnableToDeside()) { }

        public PizzaStrategy(IOrderPizza _orderPizza)
        {
            this._orderPizza = _orderPizza;
        }
        public string GetOrderDetails() => _orderPizza.OrderPizza();


        public void PlaceOrder(IPizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
