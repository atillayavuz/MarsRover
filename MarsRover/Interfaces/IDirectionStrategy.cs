using MarsRover.Common.Enums;
using MarsRover.Common.Model;

namespace MarsRover.Interfaces
{
    public interface IDirectionStrategy
    {
        Direction TurnLeft();
        Direction TurnRight();
        Coordinate MoveForward();
    }
}
