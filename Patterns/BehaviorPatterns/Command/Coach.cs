namespace Command
{
    public class Coach
    {
        ICommand command;
        public Coach()
        {

        }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ScreamToStart()
        {
            command.Execute();
        }
        public void ScreamToStop()
        {
            command.Undo();
        }
    }
}
