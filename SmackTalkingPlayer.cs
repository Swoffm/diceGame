using System;
using System.Collections.Generic;
namespace ShootingDice

{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        private List<string> insultList = new List<string>()
        {
            "boo",
            "you suck",
            "you're going to loose",
            "your mama sucks"
        };

        public void roll()
        {
            int randomInsultIndex = new Random().Next(insultList.Count);
            Console.WriteLine(insultList[randomInsultIndex]);
        }
    }
}