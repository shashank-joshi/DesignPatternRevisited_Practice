using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer.Weak_References_PizzaDelivery_Subject
{
    public interface IPizzaSubjectWeakReferences
    {
        WeakReference<ITargetObserver> RegisterObserver(ITargetObserver targetObserver);
        void UnregisterObserver(WeakReference<ITargetObserver> weakReferenceObserver);
        void NotifyObservers(PizzaDeleveryStatus pizzaDeleveryStatus);
    }
}
