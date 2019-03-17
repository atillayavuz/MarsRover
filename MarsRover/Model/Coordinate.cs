namespace MarsRover.Common.Model
{
    public class Coordinate
    {
        public Coordinate(int XCoordinate, int YCoordinate)
        {
            this.XCoordinate = XCoordinate;
            this.YCoordinate = YCoordinate;
        }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public override string ToString()
        {
            return $"{ XCoordinate } { YCoordinate }";
        }
    }
}
