using DesignPatterns.Structural.Decorator;
using Xunit;

namespace DesignPattern.StructuralPattern.Test
{
    public class DecoratorTest
    {
        [Fact]
        public void BaseProperties()
        {
            IPizzaDecorator basicPizzaBase = new BasicPizzaBase();
            Assert.Equal(25, basicPizzaBase.PizzaBase());
            Assert.Equal(49.25, basicPizzaBase.Cost());
        }
        [Fact]
        public void SmallPizzaProperties()
        {
            IPizzaDecorator basicPizzaBase = new BasicPizzaBase();
            IPizzaDecorator smallPizzaDecorator = new SmallPizzaDecorator(basicPizzaBase);
            Assert.Equal(10, smallPizzaDecorator.PizzaBase());
            Assert.Equal(43.80, smallPizzaDecorator.Cost());
        }
        [Fact]
        public void MediumPizzaProperties()
        {
            IPizzaDecorator basicPizzaBase = new BasicPizzaBase();
            IPizzaDecorator mediumPizzaDecorator = new MediumPizzaBase(basicPizzaBase);
            Assert.Equal(25, mediumPizzaDecorator.PizzaBase());
            Assert.Equal(49.25, mediumPizzaDecorator.Cost());
        }
        [Fact]
        public void LargePizzaProperties()
        {
            IPizzaDecorator basicPizzaBase = new BasicPizzaBase();
            IPizzaDecorator largePizzaDecorator = new LargePizzaBase(basicPizzaBase);
            Assert.Equal(45, largePizzaDecorator.PizzaBase());
            Assert.Equal(74.75, largePizzaDecorator.Cost());
        }
    }
}
