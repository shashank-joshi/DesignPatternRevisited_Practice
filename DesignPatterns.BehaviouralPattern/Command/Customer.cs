using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Command
{
    public class Customer
    {
        private readonly StringBuilder stringBuilder = new StringBuilder();
        private readonly List<IOrderCommand> orderCommands = new List<IOrderCommand>();

        public IOrderCommand GetOrderCommand(int position)
        {
            return orderCommands[position];
        }
        public int PlaceOrderCommand(IOrderCommand orderCommand)
        {
            orderCommand.sbOrderText = stringBuilder;
            orderCommands.Add(orderCommand);
            return orderCommands.IndexOf(orderCommand);
        }
        public void CancelOrderCommand(int position)
        {
            orderCommands.RemoveAt(position);
        }
        public string GetOrderString()
        {
            return stringBuilder.ToString();
        }
    }
}
