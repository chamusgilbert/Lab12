using System;

namespace Lab12
{
    class OpponentRandy : Player
    {

        public override Answer GetGameValue()
        {
            Answer shoot = new Answer("");
            Random oneTwoThree = new Random();
            int playNumber = oneTwoThree.Next(1, 4);
            if (playNumber == 1)
            {
                shoot = new Answer("rock");
            }
            else if (playNumber == 2)
            {
                shoot = new Answer("paper");
            }
            else
            {
                shoot = new Answer("scissors");
            }

            return shoot;
        }
    }
}

