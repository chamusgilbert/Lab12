using System;
namespace Lab12
{
    class Controller
    {
        public Controller()
        {
            View.BeginGame();
            Answer opponent = View.Difficulty();
            Answer player = new Player().GetGameValue();
            Console.WriteLine("You said {0} and your opponent said {1}", player.name, opponent.name);

        }


    }

}

