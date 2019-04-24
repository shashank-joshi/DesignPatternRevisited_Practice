using DesignPatterns.BehaviouralPattern.Strategy;
using DesignPatterns.Core;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class StrategyPatternTest
    {
        [Fact]
        public void OrderSmallPizza()
        {
            IOrder orderSmallPizza = new SmallPizzaStrategy();
            Assert.Equal(orderSmallPizza.GetOrderDetails(), new OrderSmallPizza().OrderPizza());
        }
        [Fact]
        public void OrderMediumPizza()
        {
            IOrder orderMediumPizza = new MediumPizzaStrategy();
            Assert.Equal(orderMediumPizza.GetOrderDetails(), new  OrderMediumPizza().OrderPizza());
        }
        [Fact]
        public void OrderLargePizza()
        {
            IOrder orderLargePizza = new LargePizzaStrategy();
            Assert.Equal(orderLargePizza.GetOrderDetails(), new OrderLargePizza().OrderPizza());
        }
        [Fact]
        public void ChangeOrder()
        {
            IOrder orderSmallPizza = new SmallPizzaStrategy();
            Assert.Equal(orderSmallPizza.GetOrderDetails(), new OrderSmallPizza().OrderPizza());
            orderSmallPizza.ChangeOrder(new MediumPizza());
            Assert.Equal(orderSmallPizza.GetOrderDetails(), new OrderMediumPizza().OrderPizza());
            orderSmallPizza.ChangeOrder(new LargePizza());
            Assert.Equal(orderSmallPizza.GetOrderDetails(), new OrderLargePizza().OrderPizza());
        }
    }
}
