using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Common.Model;
using MarsRover.Interfaces;

namespace MarsRover.Concreate.Directions
{
    public class WestDirection : IDirectionStrategy
    {
        public Position RoverPosition { get; set; }

        public WestDirection(Position RoverPosition)
        {
            this.RoverPosition = RoverPosition;
        }

        public Direction TurnLeft()
        {
            return Direction.S;
        }

        public Direction TurnRight()
        {
            return Direction.N;
        }

        public Coordinate MoveForward()
        {
            if (Mars.Coordinate.XCoordinate == 0)
            {
                throw new RoverException(ExceptionConst.RoverExceptionMessage);
            }

            return new Coordinate(this.RoverPosition.Coordinate.XCoordinate - 1, this.RoverPosition.Coordinate.YCoordinate);
        }
    }
}
