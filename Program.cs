using DroneAircraft;
using System;
using System.Text.RegularExpressions;


namespace DroneSimulation
{
      class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone();

            while (true)
            {
                Console.Write("Enter command: ");
                string input = Console.ReadLine().Trim().ToUpper();               

                if (input.StartsWith("LAUNCH"))
                {
                    string pattern = @"^LAUNCH -?\d+,-?\d+,(NORTH|SOUTH|EAST|WEST)$";
                    Regex rg = new Regex(pattern);

                    // check if the command matches the pattern
                    if (rg.IsMatch(input))
                    {
                        string[] parts = input.Split(' ');
                        int newX = int.Parse(parts[1].Split(',')[0]);
                        int newY = int.Parse(parts[1].Split(',')[1]);                   
                        Direction newFacing = (Direction)Enum.Parse(typeof(Direction), parts[1].Split(',')[2]);
                        drone.Launch(newX, newY, newFacing);                  
                       
                    }
                    else
                    {
                        Console.WriteLine("the command is typed incorrectly; consider this instruction :launch digit,digit,north|south|east|west");
                    }
                    
                                        
                    
                }
                else if (input == "FLY")
                {
                    drone.Fly();
                }
                else if (input == "LEFT")
                {
                    drone.TurnLeft();
                }
                else if (input == "RIGHT")
                {
                    drone.TurnRight();
                }
                else if (input == "STATUS")
                {
                    drone.Status();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try again.");
                }
            }
        }
    }
}
