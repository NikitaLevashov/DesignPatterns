using PatternFactoryMethod;
using PatternSingleton;
using PatternStrategy;
using System;
using OperatingSystem = PatternSingleton.OperatingSystem;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализация паттерна Singleton
            Phone phone = new Phone();
            phone.Launch("Android 12.0");
            Console.WriteLine(phone.OperatingSystem.Name);

            phone.OperatingSystem = OperatingSystem.getOperatingSystem("IOS 9.0");
            Console.WriteLine(phone.OperatingSystem.Name);

            Console.ReadKey();

            // Реализация паттерна Factory Method
            Developer developer = new CSharpDeveloper("C# разработчик");
            Application applicationCSharp = developer.Create();

            developer = new JavaDeveloper("Java разработчик");
            Application applicationJava = developer.Create();

            developer = new PythonDeveloper("Python разработчик");
            Application applicationPython = developer.Create();

            Console.ReadKey();

            // Реализация паттерна Strategy
            Controller controller = new Controller(new AdoProductRepository());
            controller.Index();

            controller._repository = new EFProductRepository();
            controller.Index();

            controller._repository = new DataClientProductRepository();
            controller.Index();

            Console.ReadKey();
            
            // Реализация паттерна Template Method











        }
    }
}
