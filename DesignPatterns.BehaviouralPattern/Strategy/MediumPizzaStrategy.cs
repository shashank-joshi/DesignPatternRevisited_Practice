using DesignPatterns.Core;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public  class MediumPizzaStrategy : PizzaStrategy
    {
        public MediumPizzaStrategy() : base(new MediumPizza()) { }
    }
}
