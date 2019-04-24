namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public class UnableToDeside : IOrderPizza
    {
        public string OrderPizza()
        {
            return "Leave it; will have something else!!!!";
        }
    }
}
