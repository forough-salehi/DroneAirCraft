using DroneAircraft;
using System;

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
                    
                    string[] parts = input.Split(' ');
                    int newX = int.Parse(parts[1].Split(',')[0]);
                    int newY = int.Parse(parts[1].Split(',')[1]);
                    try
                    { 
                        Direction newFacing = (Direction)Enum.Parse(typeof(Direction), parts[1].Split(',')[2]);
                        drone.Launch(newX, newY, newFacing);
                    }
                    catch (ArgumentException )
                    {
                        Console.WriteLine("the command is typed incorrectly; please write the direction in correct dictation such as :north,south,east,west ");
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
