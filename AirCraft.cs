using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneAircraft
{
    public class AirCraft
    {

        private int x;
        private int y;
        protected Direction facing;
        protected bool inAir;

        public AirCraft()
        {
            x = 0;
            y = 0;
            facing = Direction.NORTH;
            inAir = false;
        }

        public void Launch(int newX, int newY, Direction newFacing)
        {
            if (newX <= 5 && newX >= 0 && newY <= 5 && newX >= 0)
            {
                x = newX;
                y = newY;
                facing = newFacing;
                inAir = true;
            }
            else
            {
                Console.WriteLine("you cannot go to this point, as it is out of the area.");
            }
        }

        public void Fly()
        {
            if (inAir)
            {
                switch (facing)
                {
                    case Direction.NORTH:
                        if ((y - 1) >= 0)
                            y--;
                        else
                            Console.WriteLine(" you cannot go to this point, as it is out of the area");
                        break;
                    case Direction.SOUTH:
                        if ((y + 1) <= 5)
                            y++;
                        else
                            Console.WriteLine(" you cannot go to this point, as it is out of the areaa");
                        break;
                    case Direction.EAST:
                        if ((x + 1) <= 5)
                            x++;
                        else
                            Console.WriteLine(" you cannot go to this point, as it is out of the area");
                        break;
                    case Direction.WEST:
                        if ((x - 1) >= 0)
                            x--;
                        else
                            Console.WriteLine(" you cannot go to this point, as it is out of the area");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Drone is not in the air.");
            }
        }
        public void Status()
        {
            if (inAir)
            {
                Console.WriteLine($"Current position: {x}, {y},{facing}");
            }
            else
            {
                Console.WriteLine("Drone is not in the air.");
            }
        }

    }
}
