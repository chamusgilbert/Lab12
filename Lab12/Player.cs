using System;

namespace Lab12
{
    class Player
    {

        public virtual Answer GetGameValue()
        {
            Console.WriteLine("Get ready to play Rock, Paper, Scissors");
            Console.WriteLine("1, 2, 3.......");
            Console.WriteLine("Shoot");

            string userShoot = Console.ReadLine().ToLower();
            Console.WriteLine(userShoot);
            Answer player = new Answer(userShoot);
            return player;

        }
    }
}
