using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer
{
    public class PizzaDeleverySubject : IPizzaDeleverySubject
    {
        public readonly List<ITargetObserver> targetObservers = new List<ITargetObserver>();

        public void AddPizzaStatus(PizzaDeleveryStatus pizzaDeleveryStatus)
        {
            NotifyObserver(pizzaDeleveryStatus);
        }
        public void NotifyObserver(PizzaDeleveryStatus pizzaDeleveryStatus)
        {
            targetObservers.ForEach(x => x.Update(pizzaDeleveryStatus));
        }

        public void RegisterObserver(ITargetObserver targetObserver)
        {
            targetObservers.Add(targetObserver);

        }

        public void UnregisterObserver(ITargetObserver targetObserver)
        {
            targetObservers.Remove(targetObserver);
        }
    }
}
