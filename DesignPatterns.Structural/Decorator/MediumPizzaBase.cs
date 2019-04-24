namespace DesignPatterns.Structural.Decorator
{
    public class MediumPizzaBase:IPizzaDecorator
    {
        private readonly IPizzaDecorator _pizzaDecorator;
        public MediumPizzaBase() : this(new BasicPizzaBase()) { }
        public MediumPizzaBase(IPizzaDecorator pizzaDecorator)
        {
            _pizzaDecorator = pizzaDecorator;
        }
        public int PizzaBase() => _pizzaDecorator.PizzaBase();
        public double Cost() => _pizzaDecorator.Cost();
    }
}
