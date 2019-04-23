using CreationalPatterns.AbstractFactory;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.SimpleFactory_Not_A_True_Pattern_;
using CreationalPatterns.Singalton;
using DesignPatterns.Core;
using System;
using System.Collections.Generic;

namespace DesignPatternRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Design Patterns ---------");
            Console.WriteLine("---------- A. Singletone ---------");

            Singleton singleton1 = Singleton.Instance;
            singleton1.TestInt = "singleton - 1";

            Console.WriteLine("A. First Object {0} has Hashcode: {1}", singleton1.TestInt, singleton1.GetHashCode());

            Singleton singleton2 = Singleton.Instance;
            singleton2.TestInt = "singleton - 2";

            Console.WriteLine("B. Second Object {0} has Hashcode: {1}", singleton2.TestInt, singleton2.GetHashCode());

            if (singleton1.GetHashCode() == singleton2.GetHashCode())
                Console.WriteLine("{0} = {1}", "singleton1", "singleton2");


            Console.WriteLine("---------- B. Simple Factory ---------");
            Console.WriteLine("Please enter pizza topings:");
            List<string> list = new List<string>();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                list.Add(Console.ReadLine());
            }




            SimpleFactory.CreatePizza(PizzaType.Large, list).CheckObject(SimpleFactory.pizza);
            SimpleFactory.CreatePizza(PizzaType.Small, list).CheckObject(SimpleFactory.pizza);

            Console.WriteLine("---------- B. Factory Method---------");
            Console.WriteLine("Please enter pizza topings for small pizza:");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                list.Add(Console.ReadLine());
            }

            IPizza smallPizza = new SmallPizzaBase().OrderPizza(list);
            Console.WriteLine("Please enter pizza topings for medium pizza:");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                list.Add(Console.ReadLine());
            }
            IPizza mediumPizza = new MediumPizzaBase().OrderPizza(list);

            Console.WriteLine("Please enter pizza topings for large pizza:");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                list.Add(Console.ReadLine());
            }
            IPizza largePizza = new LargPizzaBase().OrderPizza(list);

            Console.WriteLine("---------- C. Abstract Factory ---------");
            Console.WriteLine("Please enter pizza topings for small pizza:");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                list.Add(Console.ReadLine());
            }


            IPizza smallPizzaAF = new ThePizzaFactory(new CreationalPatterns.AbstractFactory.SmallPizzaAF()).OrderPizza(list);
            IPizza largePizzaAF = new ThePizzaFactory(new CreationalPatterns.AbstractFactory.LargePizzaAF()).OrderPizza(list);
            IPizza mediumPizzaAF = new ThePizzaFactory(new CreationalPatterns.AbstractFactory.MediumPizzaAF()).OrderPizza(list);
            IPizza customPizzaAF = new ThePizzaFactory(new CreationalPatterns.AbstractFactory.CustomPizzaAF()).OrderPizza(list);


        }
    }

}
