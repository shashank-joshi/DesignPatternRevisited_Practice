namespace DesignPatterns.Structural.Decorator
{
    public class BasicPizzaBase : IPizzaDecorator
    {
        public int PizzaBase() => 25;
        public double Cost() => 49.25;
    
    }
}
