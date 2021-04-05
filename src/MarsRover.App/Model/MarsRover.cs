using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Model
{
    public class MarsRover : IRover, IMarsRover
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public DirectionEnum Direction { get; set; }
        public MarsRover(int xPosition, int yPosition, DirectionEnum direction)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Direction = direction;
        }

        public string Process(string directives)
        {
            foreach (var directive in directives)
            {
                switch (directive)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        return "Incorrect directive!!!";
                }
            }
            return "";
        }

        public string CurrentLocation()
        {
            return string.Format("{0} {1} {2}", XPosition, YPosition, Direction);
        }

        public void TurnLeft()
        {
            Direction = (Direction - 1) < DirectionEnum.N ? DirectionEnum.W : Direction - 1;
        }

        public void TurnRight()
        {
            Direction = (Direction + 1) > DirectionEnum.W ? DirectionEnum.N : Direction + 1;
        }

        public void Move()
        {
            switch (Direction)
            {
                case DirectionEnum.N:
                    YPosition++;
                    break;
                case DirectionEnum.E:
                    XPosition++;
                    break;
                case DirectionEnum.S:
                    YPosition--;
                    break;
                case DirectionEnum.W:
                    XPosition--;
                    break;
            }
        }
    }
}
