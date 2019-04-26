using System;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer
{
    public class PizzaDeleveryStatus
    {
        public string DeliveredPizza { get; set; }
        public string WrongOrderDelivered { get; set; }
        public string PaymentReceived { get; set; }
        public string OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
