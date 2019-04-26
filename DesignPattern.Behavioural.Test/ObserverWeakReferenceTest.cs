using DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer;
using DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer.Weak_References_PizzaDelivery_Subject;
using System;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class ObserverWeakReferenceTest
    {
        [Fact]
        public void NotifyObserver()
        {
            var pizzaDeleverySubject = new PizzaDeleveryStatusWeakReference();
            ITargetObserver storeObserver = new PizzaStore();
            ITargetObserver customerObserver = new Customer();
            var weakStoreObserver = pizzaDeleverySubject.RegisterObserver(storeObserver);
            var weakCustomerObserver = pizzaDeleverySubject.RegisterObserver(customerObserver);
            PizzaDeleveryStatus pizzaDeleveryStatus = new PizzaDeleveryStatus
            {
                DeliveredPizza = "Pizza Delivered Successfully!!!",
                OrderDetails = "5 Small Pizza",
                PaymentReceived = "INR 239=00 Received",
                OrderDate = DateTime.Today
            };
            pizzaDeleverySubject.AddPizzaStatus(pizzaDeleveryStatus);
            Assert.Equal(1, storeObserver.pizzaDeleveryStatuses.Count);
            Assert.Equal(1, customerObserver.pizzaDeleveryStatuses.Count);
            Assert.Same(pizzaDeleveryStatus, customerObserver.pizzaDeleveryStatuses[0]);
            Assert.Same(pizzaDeleveryStatus, storeObserver.pizzaDeleveryStatuses[0]);
            pizzaDeleverySubject.UnregisterObserver(weakStoreObserver);
            pizzaDeleverySubject.UnregisterObserver(weakCustomerObserver);
            Assert.Equal(0, pizzaDeleverySubject.weakReferenceObservers.Count);
        }
       [Fact(Skip = "On hold")]
        public void NullReferenceTest()
        {
            var pizzaDeleverySubject = new PizzaDeleveryStatusWeakReference();
            var storeObserver = new PizzaStore();
            var customerObserver = new Customer();
            var weakStoreObserver = pizzaDeleverySubject.RegisterObserver(storeObserver);
            var weakCustomerObserver = pizzaDeleverySubject.RegisterObserver(customerObserver);
            storeObserver = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            PizzaDeleveryStatus pizzaDeleveryStatus = new PizzaDeleveryStatus
            {
                DeliveredPizza = "Pizza Delivered Successfully!!!",
                OrderDetails = "5 Small Pizza",
                PaymentReceived = "INR 239=00 Received",
                OrderDate = DateTime.Today
            };
            pizzaDeleverySubject.AddPizzaStatus(pizzaDeleveryStatus);

            foreach (var observer in pizzaDeleverySubject.weakReferenceObservers)
            {
                observer?.TryGetTarget(out var obs);

            }
            pizzaDeleverySubject.UnregisterObserver(weakCustomerObserver);
            Assert.Equal(0, pizzaDeleverySubject.weakReferenceObservers.Count);
        }
    }
}