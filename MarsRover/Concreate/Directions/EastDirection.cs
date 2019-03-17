using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Common.Model;
using MarsRover.Interfaces;

namespace MarsRover.Concreate.Directions
{
    public class EastDirection : IDirectionStrategy
    {
        public Position RoverPosition { get; set; }

        public EastDirection(Position RoverPosition)
        {
            this.RoverPosition = RoverPosition;
        }

        public Direction TurnLeft()
        {
            return Direction.N;
        }

        public Direction TurnRight()
        {
            return Direction.S;
        }

        public Coordinate MoveForward()
        {
            if (Mars.Coordinate.XCoordinate <= this.RoverPosition.Coordinate.XCoordinate)
            {
                throw new RoverException(ExceptionConst.RoverExceptionMessage);
            }

            return new Coordinate(this.RoverPosition.Coordinate.XCoordinate + 1, this.RoverPosition.Coordinate.YCoordinate);
        } 
    } 
}
