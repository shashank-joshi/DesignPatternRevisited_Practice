using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adaptor
{
    public interface IBurger
    {
        void Bake();
        void CookTiki();
        void Deliver();
    }
}
