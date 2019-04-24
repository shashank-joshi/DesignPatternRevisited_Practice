using DesignPatterns.Core;
using System;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class PizzaStrategy : IOrder
    {
        private IPizza _orderPizza;
        public PizzaStrategy() : this(new NoPizza()) { }

        public PizzaStrategy(IPizza _orderPizza)
        {
            this._orderPizza = _orderPizza;
        }
        public string GetOrderDetails() => _orderPizza.OrderPizza();
        public void ChangeOrder(IPizza pizza)
        {
            _orderPizza = pizza;
        }



    }
}
