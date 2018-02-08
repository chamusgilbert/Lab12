namespace Lab12
{
    class OpponentRocky : Player
    {
        public override Answer GetGameValue()
        {
            Answer rocky = new Answer("rock");
            return rocky;
        }
    }
}
