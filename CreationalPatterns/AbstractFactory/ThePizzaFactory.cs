namespace CreationalPatterns.AbstractFactory
{
    public class ThePizzaFactory : PizzaBaseFactory
    {
        protected ThePizzaFactory():this(new SmallPizzaAF()){ }
        public ThePizzaFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }
    }
}
