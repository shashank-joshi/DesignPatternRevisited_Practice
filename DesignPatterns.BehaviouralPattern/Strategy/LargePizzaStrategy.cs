using DesignPatterns.Core;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class LargePizzaStrategy:PizzaStrategy
    {
        public LargePizzaStrategy() : base(new LargePizza()) { }
    }
}
