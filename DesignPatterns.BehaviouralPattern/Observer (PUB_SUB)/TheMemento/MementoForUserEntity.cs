using System;

namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento
{
    internal class MementoForUserEntity
    {
        private User user;

        public MementoForUserEntity(User user)
        {
            this.user = user.Clone();
        }

        public User GetUser()
        {
            return user;
        }
    }
}