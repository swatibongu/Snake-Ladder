using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class WinningPostion_UC4
    {
        //Constants
        public const int Ladder = 1;
        public const int Snake = 2;

        public void SnakeLadder()
        {
            //variables
            int position1 = 0;
            int dieRoll = 0;

            Console.WriteLine("Initial Position of Player 1 is :" + position1);

            while (position1 < 100)
            {
                //Random function to roll die 1 to 6
                Random random = new Random();
                //range taken from 1 to 7 due to die have 1 to 6 numbers
                dieRoll = random.Next(1, 7);

                //Console.WriteLine("Die Roll :" + dieRoll);
                //position1 = dieRoll;
                //Console.WriteLine("Position1 of player after dieRoll is :" + position1);

                int options = random.Next(0, 3);
                //Console.WriteLine("After getting Random Option is :" + options);

                //using switch case to check options
                switch (options)
                {
                    case Ladder:
                        Console.WriteLine("In option we getting Ladder");
                        position1 += dieRoll;
                        Console.WriteLine("New position1 after getting Ladder :" + position1);
                        if (position1 > 100)
                            position1 = 100;
                        break;

                    case Snake:
                        Console.WriteLine("In option player bit by snake");
                        position1 -= dieRoll;
                        Console.WriteLine("\"New position1 after snake bit :" + position1);

                        //check if position is zero after snake bit then given position zero
                        if (position1 < 0)
                            position1 = 0;
                        Console.WriteLine("Player position1 after snake bit need to start from previous position : " + position1);
                        break;

                    default:
                        Console.WriteLine("In option we got No play :" + position1);
                        break;
                }
                Console.WriteLine("Current position of player is :" + position1);
            }
            Console.WriteLine("Player position1 reaches 100 and he wins at :" + position1);
        }
    }
}