using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverTests
    {
        [Theory, InlineData("5 5 5 N\r\nLMLM")]
        public void Should_Throw_Exception(string nasaCommands)
        {
            RoverManager roverManager = new RoverManager(new InputParser(nasaCommands));
            Assert.Equal("1 3 N\r\n5 1 E\r\n", roverManager.Navigate());
        }

        [Theory, InlineData("5 5\n1 2 N\nMMMMMMM\n3 3 E\nMMRMMRMRRM")]
        public void Should_Throw_RoverException(string nasaCommands)
        {
            RoverManager roverManager = new RoverManager(new InputParser(nasaCommands)); 
            Assert.Throws<RoverException>(() => roverManager.Navigate()); 
        }

        [Theory, InlineData("5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM")]
        public void Should_Return_Expected_Positions(string nasaCommands)
        {
            RoverManager roverManager = new RoverManager(new InputParser(nasaCommands));
            Assert.Equal("1 3 N\r\n5 1 E\r\n", roverManager.Navigate());
        }
    }
}
