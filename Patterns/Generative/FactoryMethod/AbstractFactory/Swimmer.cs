namespace AbstractFactory
{
    public class Swimmer : SportsmanFactory
    {
        public override SportWear CreateWear()
        {
            return new Swimsuit();
        }

        public override Action CreateAction()
        {
            return new SwimAction();
        }
    }
}
