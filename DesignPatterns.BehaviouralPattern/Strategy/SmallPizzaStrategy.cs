using DesignPatterns.Core;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class SmallPizzaStrategy:PizzaStrategy
    {
        public SmallPizzaStrategy() : base(new SmallPizza()) { }
    }
}
