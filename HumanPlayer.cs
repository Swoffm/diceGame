using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        private int rollInt;
        public override int Roll()
        {
            bool stringParse = false;
            while (!stringParse)
            {

                Console.Write("What number would you like to roll");
                string userResponse = Console.ReadLine();


                bool userInt = Int32.TryParse(userResponse, out rollInt);
                if (userInt)
                {
                    break;
                }

            }
            return rollInt;

        }
    }
}