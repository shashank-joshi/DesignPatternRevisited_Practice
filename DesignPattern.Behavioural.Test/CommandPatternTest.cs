using DesignPatterns.BehaviouralPattern.Command;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class ComandPatterntest
    {
        [Fact]
        public void PlaceOrder()
        {
            var controller = new Customer();
            var orderCommandReference = controller.PlaceOrderCommand(new PlaceOrderCommand());
            var expected = "Small Pizza";
            controller.GetOrderCommand(orderCommandReference).PlaceOrder(expected);
            Assert.Equal(expected, controller.GetOrderString());
        }
        [Fact]
        public void CancelOrder()
        {
            var controller = new Customer();
            var orderCommandReference = controller.PlaceOrderCommand(new PlaceOrderCommand());
            var expected = "Small Pizza";
            controller.GetOrderCommand(orderCommandReference).PlaceOrder(expected);
            controller.GetOrderCommand(orderCommandReference).PlaceOrder("Large Pizza");
            controller.GetOrderCommand(orderCommandReference).CancelOrder();
            Assert.Equal(expected, controller.GetOrderString());
        }
    }
}
