using System;
namespace ShootingDice

{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        private string insult = "you suck";

        public override int Roll()
        {
            Console.WriteLine(insult);
            return base.Roll();
        }
    }
}