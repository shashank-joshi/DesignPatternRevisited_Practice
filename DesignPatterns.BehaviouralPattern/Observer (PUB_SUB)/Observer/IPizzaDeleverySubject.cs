using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer
{
    public interface IPizzaDeleverySubject
    {
        void RegisterObserver(ITargetObserver targetObserver);
        void UnregisterObserver(ITargetObserver targetObserver);
        void NotifyObserver(PizzaDeleveryStatus pizzaDeleveryStatus);
    }
}
