using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {

        public override int Roll()
        {
            double upperHalf = (base.DiceSize - (base.DiceSize / 2));
            upperHalf = (Math.Floor(upperHalf));
            int upperRoll = Convert.ToInt32(upperHalf);

            return new Random().Next(upperRoll, DiceSize) + 1;
        }
    }
}