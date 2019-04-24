using System.Text;

namespace DesignPatterns.BehaviouralPattern.Command
{
    public interface IOrderCommand
    {
        StringBuilder sbOrderText { get; set; }
        void PlaceOrder(string order);
        void CancelOrder();
    }
}
