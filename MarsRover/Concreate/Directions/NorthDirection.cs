using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Common.Model;
using MarsRover.Interfaces;

namespace MarsRover.Concreate.Directions
{
    public class NorthDirection : IDirectionStrategy
    {
        public Position RoverPosition { get; set; }

        public NorthDirection(Position RoverPosition)
        {
            this.RoverPosition = RoverPosition;
        }

        public Direction TurnLeft()
        {
            return Direction.W;
        }

        public Direction TurnRight()
        {
            return Direction.E;
        }

        public Coordinate MoveForward()
        {
            if (Mars.Coordinate.YCoordinate <= this.RoverPosition.Coordinate.YCoordinate)
            {
                throw new RoverException(ExceptionConst.RoverExceptionMessage);
            }

            return new Coordinate(this.RoverPosition.Coordinate.XCoordinate, this.RoverPosition.Coordinate.YCoordinate + 1);
        }

    }
}
