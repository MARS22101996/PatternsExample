namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var coach = new Coach();
            var footballTeam = new FootballTeam();
            coach.SetCommand(new FootballCommand(footballTeam));
            coach.ScreamToStart();
            coach.ScreamToStop();
        }
    }
}