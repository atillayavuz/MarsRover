using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Common.Model;
using MarsRover.Interfaces;

namespace MarsRover.Concreate.Directions
{
    public class SouthDirection : IDirectionStrategy
    {
        public Position RoverPosition { get; set; }

        public SouthDirection(Position RoverPosition)
        {
            this.RoverPosition = RoverPosition;
        }

        public Direction TurnLeft()
        {
            return Direction.E;
        }

        public Direction TurnRight()
        {
            return Direction.W;
        }

        public Coordinate MoveForward()
        {
            if (this.RoverPosition.Coordinate.YCoordinate == 0)
            {
                throw new RoverException(ExceptionConst.RoverExceptionMessage);
            }

            return new Coordinate(this.RoverPosition.Coordinate.XCoordinate, this.RoverPosition.Coordinate.YCoordinate - 1);
        }
    }
}
