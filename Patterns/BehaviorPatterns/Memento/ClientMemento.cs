namespace Memento
{
    public class ClientMemento
    {
        public int Balance { get; private set; }

        public ClientMemento(int balance)
        {
            Balance = balance;
        }
    }
}
