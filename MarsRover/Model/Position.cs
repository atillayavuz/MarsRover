using MarsRover.Common.Enums;

namespace MarsRover.Common.Model
{
    public class Position
    {
        public Position(int XCoordinate, int YCoordinate, Direction Direction)
        {
            Coordinate = new Coordinate(XCoordinate, YCoordinate);
            this.Direction = Direction;
        }
        public Coordinate Coordinate { get; set; }

        public Direction Direction { get; set; }

        public override string ToString()
        {
            return $"{ Coordinate.ToString() } { Direction }";
        }
    }
}
