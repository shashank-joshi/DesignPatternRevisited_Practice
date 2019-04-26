using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer.Weak_References_PizzaDelivery_Subject
{
    public class PizzaDeleveryStatusWeakReference : IPizzaSubjectWeakReferences
    {
        public readonly List<WeakReference<ITargetObserver>> weakReferenceObservers 
                                                    = new List<WeakReference<ITargetObserver>>();
        public void AddPizzaStatus(PizzaDeleveryStatus pizzaDeleveryStatus)
        {
            NotifyObservers(pizzaDeleveryStatus);
        }
        public void NotifyObservers(PizzaDeleveryStatus pizzaDeleveryStatus)
        {
            foreach (var observer in weakReferenceObservers)
            {
                observer.TryGetTarget(out ITargetObserver targetObserver);
                if (targetObserver == null)
                    UnregisterObserver(observer);
                else
                    targetObserver.Update(pizzaDeleveryStatus);
            }
        }

        public WeakReference<ITargetObserver> RegisterObserver(ITargetObserver targetObserver)
        {
            var weakReference = new WeakReference<ITargetObserver>(targetObserver);
            weakReferenceObservers.Add(weakReference);
            return weakReference;
        }

        public void UnregisterObserver(WeakReference<ITargetObserver> weakReferenceObserver)
        {
            weakReferenceObservers.Remove(weakReferenceObserver);
        }
    }
}
