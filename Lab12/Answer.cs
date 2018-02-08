namespace Lab12
{
    class Answer
    {
        public string name;
        public Answer(string userInput)
        {
            if (userInput == "rock")
            {
                ChooseRock();
            }
            else if (userInput == "paper")
            {
                ChoosePaper();
            }
            else
            {
                ChooseScissors();
            }

        }

        public void ChooseRock()
        {
            name = "Rock";
        }
        public void ChoosePaper()
        {
            name = "Paper";
        }
        public void ChooseScissors()
        {
            name = "Scissors";
        }

    }

}
