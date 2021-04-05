using MarsRover.App.Factory;
using MarsRover.App.Model;
using System;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();
            Console.WriteLine("Expected Output:");

            RoverFactory factory = new ConcreteRoverFactory();
            IRover marsRover = factory.GetRover(RoverTypeEnum.Mars, 1, 2, DirectionEnum.N);
            marsRover.Process("LMLMLMLMM");
            Console.WriteLine(marsRover.CurrentLocation());

            IRover marsRover2 = factory.GetRover(RoverTypeEnum.Mars, 3, 3, DirectionEnum.E);
            marsRover2.Process("MMRMMRMRRM");
            Console.WriteLine(marsRover2.CurrentLocation());

            Console.ReadLine();
        }
    }
}
