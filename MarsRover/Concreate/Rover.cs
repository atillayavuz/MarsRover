using MarsRover.Common.Model;
using MarsRover.Interfaces;

namespace MarsRover.Concreate
{
    public class Rover : IRover
    {  
        public Position CurrentPosition { get; set; }

        public Rover(Position position)
        { 
            CurrentPosition = position; 
        }

        public void TurnLeft()
        {
            CurrentPosition.Direction = DirectionFactory.GetDirection(this.CurrentPosition).TurnLeft();
        }

        public void TurnRight()
        {
            CurrentPosition.Direction = DirectionFactory.GetDirection(this.CurrentPosition).TurnRight();
        }

        public void MoveForward()
        {
            CurrentPosition.Coordinate = DirectionFactory.GetDirection(this.CurrentPosition).MoveForward();
        }
    }
}
