using DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheTemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class TemplateMethodTest
    {
        [Fact]
        public void ShouldReturnSmallPizzaStatus()
        {
            PizzaOrderTemplate smallPizzaOrder = new SmallPizzaOrder();
            string steps = "Ordered Small Pizza"+"Baking Small Pizza " + "Making Small Pizza"+ "Processed Payment"+ "Pizza Delivered";
            Assert.Equal(steps, smallPizzaOrder.OrderPizza("Pizza"));

        }
        [Fact]
        public void ShouldReturnMediumPizzaStatus()
        {
            PizzaOrderTemplate mediumPizzaOrder = new MediumPizzaOrder();
            string steps = "Ordered Medium Pizza" + "Baking Medium Pizza " + "Making Medium Pizza" + "Pizza Delivered" + "Processed Payment" ;
            Assert.Equal(steps, mediumPizzaOrder.OrderPizza("Pizza"));

        }
        [Fact]
        public void ShouldNotMatchSteps()
        {
            PizzaOrderTemplate smallPizzaOrder = new SmallPizzaOrder();
            PizzaOrderTemplate mediumPizzaOrder = new MediumPizzaOrder();
            Assert.NotEqual(mediumPizzaOrder.OrderPizza("pizza"), smallPizzaOrder.OrderPizza("Pizza"));

        }
    }
}
