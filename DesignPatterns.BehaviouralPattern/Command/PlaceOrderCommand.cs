namespace DesignPatterns.BehaviouralPattern.Command
{
    public class PlaceOrderCommand : BaseOrderCommand
    {

        public override void CancelOrder()
        {
            var entryLength = orderEntries[orderEntries.Count - 1].Length;
            var totalLength = sbOrderText.Length;
            sbOrderText.Remove(totalLength - entryLength, entryLength);
            orderEntries.RemoveAt(orderEntries.Count-1);

        }

        public override void PlaceOrder(string order)
        {
            sbOrderText.Append(order);
            orderEntries.Add(order);

        }
    }
}
