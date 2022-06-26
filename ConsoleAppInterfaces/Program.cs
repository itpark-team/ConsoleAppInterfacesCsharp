using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleAppInterfaces.StrategyPattern;
using ConsoleAppInterfaces.InterfacesCode;
using ConsoleAppInterfaces.Polymorfizm;
using ConsoleAppInterfaces.Composition;
using ConsoleAppInterfaces.Sortirovka;

namespace ConsoleAppInterfaces
{
    internal class Program
    {

        //public static IEnumerable<int> CreateCollection(params int[] numbers)
        //{
        //    return new HashSet<int>(numbers);
        //}

        static void Main(string[] args)
        {
            //ChildClass childClass = new ChildClass();
            //childClass.Sleep();

            //Summator summator = new Summator();
            //Multiplicator multiplicator = new Multiplicator();

            //MathMachine mathMachine = new MathMachine(3, 5, summator);

            //Console.WriteLine(mathMachine.DoMath());

            //mathMachine.SetCalculator(multiplicator);

            //Console.WriteLine(mathMachine.DoMath());

            //IFlyable flyable = new Plane(10);

            //flyable.Fly();

            //IEnumerable<int> ints = new HashSet<int>();

            //Dog d1 = new Dog();
            //Cat c1 = new Cat();
            //Dog d2 = new Dog();

            //List<IAnimal> animals = new List<IAnimal>()
            //{
            //    d1,c1,d2
            //};

            //foreach (var animal in animals)
            //{
            //    animal.MakeSound();
            //}

            //WorkersManager workersManager = new WorkersManager();
            //workersManager.RunWork();

            MyArray myArray = new MyArray(5,3,2356,67);
            myArray.PrintArray();
            myArray.Sort(new OddEnvenComparator());
            myArray.PrintArray();

            Console.ReadKey();
        }
    }
}
