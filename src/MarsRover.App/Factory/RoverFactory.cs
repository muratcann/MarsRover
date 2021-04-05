using MarsRover.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Factory
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class RoverFactory
    {
        public abstract IRover GetRover(RoverTypeEnum roverType, int xPosition, int yPosition, DirectionEnum direction);
    }
}
