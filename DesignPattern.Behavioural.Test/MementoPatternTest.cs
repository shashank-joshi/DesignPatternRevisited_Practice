using DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento;
using Xunit;

namespace DesignPattern.Behavioural.Test
{
    public class MementoPatternTest
    {
        [Fact]
        public void Update_Cutomer()
        {
            var user = new User { Id = 2, Name = "Test" };
            var command = new UpdateUserCommand(user);
            var newUserName = "Testing";
            command.UpdateUser(newUserName);
            Assert
                .Equal(newUserName, command.User.Name);
        }
        [Fact]
        public void Undo_Update_User()
        {

            string originalName = "Test";
            var user = new User { Id = 2, Name = originalName };
            var command = new UpdateUserCommand(user);
            var newUserName = "Testing";
            command.UpdateUser(newUserName);
            command.UndoUpdate();
            Assert.Equal(originalName, command.User.Name);
            Assert.Equal(2, command.User.Id);
        }
    }
}
