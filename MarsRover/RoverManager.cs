using MarsRover.Concreate;
using System;
using System.Text;

namespace MarsRover
{
    public class RoverManager
    {
        public InputParser InputParser { get; set; }

        public Mars Mars { get; set; } = new Mars();

        public RoverManager(InputParser InputParser)
        {
            this.InputParser = InputParser;
            Mars.Coordinate = InputParser.GetMarsSize();
        }

        public string Navigate()
        {
            StringBuilder finalPositions = new StringBuilder();
            Rover rover = null;
            foreach (var roverPos in InputParser.GetRoversPositionAndRoute())
            {
                rover = new Rover(roverPos.Key);
                foreach (var item in roverPos.Value)
                {
                    switch (item)
                    {
                        case 'L':
                            rover.TurnLeft();
                            break;
                        case 'R':
                            rover.TurnRight();
                            break;
                        case 'M':
                            rover.MoveForward();
                            break;
                    }
                }
                finalPositions.Append(rover.CurrentPosition.ToString() + Environment.NewLine);
            }
            return finalPositions.ToString();
        }
    } 
}
