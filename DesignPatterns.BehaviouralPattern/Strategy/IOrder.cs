using DesignPatterns.Core;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public interface IOrder
    {
        string GetOrderDetails();
        void ChangeOrder(IPizza pizza);
    }
}
