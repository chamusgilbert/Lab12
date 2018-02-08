using System;

namespace Lab12
{
    class View
    {
        public static void BeginGame()
        {
            Console.WriteLine("Welcome. Let's play Rock, Paper, Scissors");
            Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock");
            Console.WriteLine();


        }
        public static Answer Difficulty()
        {

            Console.WriteLine("Who is going to be your opponent?");
            Console.WriteLine("Rocky or Randy?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "rocky")
            {
                Console.WriteLine("Here comes Rocky... He's kinda dense... go easy on him");
                Answer finalAnswer = new OpponentRocky().GetGameValue();
                return finalAnswer;

            }
            else if (userInput == "randy")
            {
                Console.WriteLine("Randy is handy. Good Luck");
                Answer finalAnswer = new OpponentRandy().GetGameValue();
                return finalAnswer;
            }
            else
            {
                Answer finalAnswer = new Answer("rock");
                return finalAnswer;
            }
        }
    }


}
