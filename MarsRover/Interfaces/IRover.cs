using MarsRover.Common.Model;

namespace MarsRover.Interfaces
{
    public interface IRover
    {  
        Position CurrentPosition { get; set; }

        void TurnLeft();

        void TurnRight();

        void MoveForward();
    }
}
