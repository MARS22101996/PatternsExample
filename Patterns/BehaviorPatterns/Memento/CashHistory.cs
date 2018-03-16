using System.Collections.Generic;

namespace Memento
{
    public class CashHistory
    {
        public Stack<ClientMemento> History { get; }

        public CashHistory()
        {
            History = new Stack<ClientMemento>();
        }
    }
}
