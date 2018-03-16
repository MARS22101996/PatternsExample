namespace AbstractFactory
{
    public class Runner : SportsmanFactory
    {
        public override Action CreateAction()
        {
            return new RunAction();
        }

        public override SportWear CreateWear()
        {
            return new Shoes();
        }
    }
}
