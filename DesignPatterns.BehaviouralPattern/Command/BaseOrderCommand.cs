﻿using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPattern.Command
{
    public abstract class BaseOrderCommand : IOrderCommand
    {
        public StringBuilder sbOrderText { get; set; }

        protected readonly List<string> orderEntries = new List<string>();

        public abstract void CancelOrder();
        public abstract void PlaceOrder(string order);
    }
}
