namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.GetMoney(100);
            var cashHistory = new CashHistory();
            cashHistory.History.Push(client.SaveState());
            client.GetMoney(100);
            client.RestoreState(cashHistory.History.Pop());
        }
    }
}