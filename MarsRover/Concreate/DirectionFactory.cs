using MarsRover.Common.Enums;
using MarsRover.Common.Model;
using MarsRover.Concreate.Directions;
using MarsRover.Interfaces;

namespace MarsRover
{
    public class DirectionFactory
    {
        public static IDirectionStrategy GetDirection(Position roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case Direction.E:
                    return new EastDirection(roverPosition);
                case Direction.N:
                    return new NorthDirection(roverPosition);
                case Direction.S:
                    return new SouthDirection(roverPosition);
                case Direction.W:
                    return new WestDirection(roverPosition); 
                default:
                    return null;
            }
        }
    }
}
