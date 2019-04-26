using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adaptor
{
    public interface IFood
    {
        void Cook();
        void Prepare();
        void Serve();
    }
}
