using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento
{
    public class UpdateUserCommand : IDataCommand
    {
        public User User { get; private set; }

        private readonly List<MementoForUserEntity> mementoForUserEntities = new List<MementoForUserEntity>();
        public void UndoUpdate()
        {
            User = (mementoForUserEntities[mementoForUserEntities.Count - 1].GetUser());
            mementoForUserEntities.RemoveAt(mementoForUserEntities.Count - 1);
        }

        public void UpdateUser(string name)
        {
            mementoForUserEntities.Add(new MementoForUserEntity(User));
            User.Name = name;
        }

        public UpdateUserCommand(User user)
        {
            User = user;
        }
    }
}
