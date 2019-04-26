using System.Collections.Generic;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer
{
    public class PizzaStore : ITargetObserver
    {
        public List<PizzaDeleveryStatus> pizzaDeleveryStatuses { get; set; } = new List<PizzaDeleveryStatus>();

        public void Update(PizzaDeleveryStatus pizzaDeleveryStatus)
        {
            pizzaDeleveryStatuses.Add(pizzaDeleveryStatus);
        }
    }
}
