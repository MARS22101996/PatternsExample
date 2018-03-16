namespace Command
{
    public class FootballCommand : ICommand
    {
        readonly FootballTeam team;

        public FootballCommand(FootballTeam teamSet)
        {
            team = teamSet;
        }
        public void Execute()
        {
            team.Start();
        }
        public void Undo()
        {
            team.Stop();
        }
    }
}
