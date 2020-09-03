using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> insultList = new List<string>()
        {
            "boo",
            "you suck",
            "you're going to loose",
            "your mama sucks"
        };

        public override int Roll()
        {
            int randomInsultIndex = new Random().Next(insultList.Count);
            Console.WriteLine(insultList[randomInsultIndex]);
            return new Random().Next(DiceSize) + 1;

        }
    }
}