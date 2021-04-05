using MarsRover.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Factory
{
    /// <summary>
    /// A ConcreteCreator class
    /// </summary>
    public class ConcreteRoverFactory : RoverFactory
    {
        public override IRover GetRover(RoverTypeEnum roverType, int xPosition, int yPosition, DirectionEnum direction)
        {
            switch (roverType)
            {
                case RoverTypeEnum.Mars:
                    return new Model.MarsRover(xPosition, yPosition, direction);
                default:
                    throw new ApplicationException(string.Format("Rover '{0}' cannot be created", roverType));
            }
        }
    }
}
