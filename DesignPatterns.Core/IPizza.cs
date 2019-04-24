namespace DesignPatterns.Core
{
    public interface IPizza
    {
       
        void CheckObject(IPizza pizza);
        void Bake();
        void Cut();
        void Box();
        string OrderPizza();
    }
}