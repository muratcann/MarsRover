using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Model
{
    /// <summary>
    /// The Rover Interface
    /// </summary>
    public interface IRover
    {
        string Process(string directives);
        string CurrentLocation();
        int XPosition { get; set; }
        int YPosition { get; set; }
        DirectionEnum Direction { get; set; }
    }

    /// <summary>
    /// The Mars Rover Interface
    /// </summary>
    public interface IMarsRover
    {
        void TurnLeft();
        void TurnRight();
        void Move();
    }
}
