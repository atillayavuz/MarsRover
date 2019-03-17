using MarsRover.Common.Enums;
using MarsRover.Common.Extensions;
using MarsRover.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{ 
    public class InputParser
    {
        private string NasaCommads;
        private string[] CommandsAsArray;

        public InputParser(string NasaCommads)
        {
            this.NasaCommads = NasaCommads;
            this.CommandsAsArray = this.NasaCommads.Split('\n');
        }

        public Coordinate GetMarsSize()
        {
            string coordinateStr = this.CommandsAsArray.First();
            int[] coordinateArr = coordinateStr.Split(" ").Select(int.Parse).ToArray();
            return new Coordinate(coordinateArr[0], coordinateArr[1]);
        }

        public Dictionary<Position, string> GetRoversPositionAndRoute()
        {
            Dictionary<Position, string> keyValuePairs = new Dictionary<Position, string>();

            List<string> roversParameters = this.CommandsAsArray.Skip(1).ToList();

            foreach (var item in roversParameters.ChunkBy(2))
            {
                string roverPosition = item.First();
                string roverMoves = item.Last();

                string[] roverPositionSplit = roverPosition.Split(" ");
                Direction direction = Extensions.ParseEnum<Direction>(roverPositionSplit[2]);

                keyValuePairs.Add(
                    new Position(Convert.ToInt32(roverPositionSplit[0]), Convert.ToInt32(roverPositionSplit[1]), direction), roverMoves);
            }
            return keyValuePairs;
        }
    }
}
