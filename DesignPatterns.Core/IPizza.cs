using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core
{
    public interface IPizza
    {
        void CheckObject(IPizza pizza);
        void Bake();
        void Cut();
        void Box();
    }
}