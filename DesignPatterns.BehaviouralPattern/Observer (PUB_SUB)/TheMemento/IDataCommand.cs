using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento
{
    public interface IDataCommand
    {
        void UpdateUser(string text);
        void UndoUpdate();
    }
}
