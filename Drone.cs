using DroneSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneAircraft
{
    public class Drone : AirCraft
    {
        public Drone() : base()
        {
                
        }
        public void TurnLeft()
        {
            if (inAir)
            {
                switch (facing)
                {
                    case Direction.NORTH:
                        facing = Direction.WEST;
                        break;
                    case Direction.SOUTH:
                        facing = Direction.EAST;
                        break;
                    case Direction.EAST:
                        facing = Direction.NORTH;
                        break;
                    case Direction.WEST:
                        facing = Direction.SOUTH;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Drone is not in the air.");
            }
        }

        public void TurnRight()
        {
            if (inAir)
            {
                switch (facing)
                {
                    case Direction.NORTH:
                        facing = Direction.EAST;
                        break;
                    case Direction.SOUTH:
                        facing = Direction.WEST;
                        break;
                    case Direction.EAST:
                        facing = Direction.SOUTH;
                        break;
                    case Direction.WEST:
                        facing = Direction.NORTH;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Drone is not in the air.");
            }
        }

        
    }

}

