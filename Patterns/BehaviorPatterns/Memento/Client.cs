using System;

namespace Memento
{
    public class Client
    {
        private int _cardBalance = 1000;

        public void GetMoney(int money)
        {
            if (_cardBalance > money)
            {
                _cardBalance = _cardBalance - money;
                Console.WriteLine($"Card balance {_cardBalance}");
            }
            else
                Console.WriteLine($"You do not have enough money - {_cardBalance}");
        }

        public ClientMemento SaveState()
        {
            Console.WriteLine($"Save balance {_cardBalance}");
            return new ClientMemento(_cardBalance);
        }

        public void RestoreState(ClientMemento memento)
        {
            this._cardBalance = memento.Balance;
            Console.WriteLine($"Restore balance {_cardBalance}");
        }
    }
}
