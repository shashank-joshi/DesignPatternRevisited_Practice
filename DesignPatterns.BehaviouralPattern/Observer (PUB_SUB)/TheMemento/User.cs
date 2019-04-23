namespace DesignPatterns.BehaviouralPattern.Observer__PUB_SUB_.TheMemento
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

      
        public User Clone()
        {
            return MemberwiseClone() as User;
        }
    }
}