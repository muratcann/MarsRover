using MarsRover.App;
using MarsRover.App.Factory;
using MarsRover.App.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class Test
    {
        RoverFactory factory;
        public Test()
        {
            factory = new ConcreteRoverFactory();
        }

        /// <summary>
        /// First Mars Rover Check
        /// </summary>
        [TestMethod]
        public void FirstMarsRoverCheck()
        {
            IRover marsRover = factory.GetRover(RoverTypeEnum.Mars, 1, 2, DirectionEnum.N);
            marsRover.Process("LMLMLMLMM");
            Assert.AreEqual(marsRover.CurrentLocation(), "1 3 N");
        }

        /// <summary>
        /// Second Mars Rover Check
        /// </summary>
        [TestMethod]
        public void SecondMarsRoverCheck()
        {
            IRover marsRover2 = factory.GetRover(RoverTypeEnum.Mars, 3, 3, DirectionEnum.E);
            marsRover2.Process("MMRMMRMRRM");
            Assert.AreEqual(marsRover2.CurrentLocation(), "5 1 E");
        }

        /// <summary>
        /// Incorrect Input Check
        /// </summary>
        [TestMethod]
        public void IncorrectInputCheck()
        {
            IRover marsRover2 = factory.GetRover(RoverTypeEnum.Mars, 1, 1, DirectionEnum.E);
            var processMessage = marsRover2.Process("LRJMRRM");
            string incorrectInputMessage = "Incorrect directive!!!";
            Assert.AreEqual(processMessage, incorrectInputMessage);
        }
    }
}
