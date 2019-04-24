namespace DesignPatterns.Structural.Decorator
{
    public class SmallPizzaDecorator:IPizzaDecorator
    {
        private readonly IPizzaDecorator _pizzaDecorator;
        public SmallPizzaDecorator():this(new BasicPizzaBase()) {

        }
        public SmallPizzaDecorator(IPizzaDecorator pizzaDecorator)
        {
            _pizzaDecorator = pizzaDecorator;
        }
        public int PizzaBase() => _pizzaDecorator.PizzaBase() - 15;
        public double Cost() => _pizzaDecorator.Cost() - 5.45;
    }
}
