namespace AbstractFactory
{
    public class Sportsman
    {
        private readonly SportWear _sportWear;
        private readonly Action _action;

        public Sportsman(SportsmanFactory factory)
        {
            _sportWear = factory.CreateWear();
            _action = factory.CreateAction();
        }

        public void Move()
        {
            _action.Move();
        }

        public void Wear()
        {
            _sportWear.Wear();
        }
    }
}