using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll()
        {
            int HigherPlayer = new Random().Next(DiceSize) + 1;
            if (HigherPlayer == 6)
            {
                return HigherPlayer;
            }
            else
            {
                return HigherPlayer++;
            }

        }
    }
}