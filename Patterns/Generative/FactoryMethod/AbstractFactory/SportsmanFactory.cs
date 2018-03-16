namespace AbstractFactory
{
    public abstract class SportsmanFactory
    {
        public abstract SportWear CreateWear();
        public abstract Action CreateAction();
    }
}