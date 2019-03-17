using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM"; 

            RoverManager roverManager = new RoverManager(new InputParser(input)); 
            string finalLocations =  roverManager.Navigate();
              
            Console.WriteLine(finalLocations); 
            Console.ReadLine();
        } 
    } 
}