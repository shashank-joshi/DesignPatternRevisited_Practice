﻿using DesignPatterns.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Strategy
{
    public interface IOrder
    {
        string GetOrderDetails();
        void ChangeOrder(IPizza pizza);
    }
}
