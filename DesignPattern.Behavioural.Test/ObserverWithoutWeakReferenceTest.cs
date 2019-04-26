using DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.Observer;
using System;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class ObserverWithoutWeakReferenceTest
    {
        [Fact]
        public void NotifyObserver() {
            var pizzaDeleverySubject = new PizzaDeleverySubject();
            ITargetObserver storeObserver = new PizzaStore();
            ITargetObserver customerObserver = new Customer();
            pizzaDeleverySubject.RegisterObserver(storeObserver);
            pizzaDeleverySubject.RegisterObserver(customerObserver);
            PizzaDeleveryStatus pizzaDeleveryStatus = new PizzaDeleveryStatus
            {
                DeliveredPizza = "Pizza Delivered Successfully!!!",
                OrderDetails = "5 Small Pizza",
                PaymentReceived = "INR 239=00 Received",
                OrderDate = DateTime.Today
            };
            pizzaDeleverySubject.AddPizzaStatus(pizzaDeleveryStatus);
            Assert.Equal(1,storeObserver.pizzaDeleveryStatuses.Count);
            Assert.Equal(1, customerObserver.pizzaDeleveryStatuses.Count);
            Assert.Same(pizzaDeleveryStatus, customerObserver.pizzaDeleveryStatuses[0]);
            Assert.Same(pizzaDeleveryStatus, storeObserver.pizzaDeleveryStatuses[0]);
            pizzaDeleverySubject.UnregisterObserver(storeObserver);
            pizzaDeleverySubject.UnregisterObserver(customerObserver);
            Assert.Equal(0, pizzaDeleverySubject.targetObservers.Count);
        }
        [Fact]
        public void NullReferenceTest()
        {
            var pizzaDeleverySubject = new PizzaDeleverySubject();
            ITargetObserver storeObserver = new PizzaStore();
            ITargetObserver customerObserver = new Customer();
            pizzaDeleverySubject.RegisterObserver(storeObserver);
            pizzaDeleverySubject.RegisterObserver(customerObserver);
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
            pizzaDeleverySubject.UnregisterObserver(storeObserver);
            pizzaDeleverySubject.UnregisterObserver(customerObserver);
            Assert.Equal(1, pizzaDeleverySubject.targetObservers.Count);
        }
    }
}
