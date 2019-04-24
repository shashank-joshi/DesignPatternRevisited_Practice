namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento
{
    public interface IDataCommand
    {
        void UpdateUser(string text);
        void UndoUpdate();
    }
}
