namespace StructurePatterns
{
    public class GreekSalad : Salad
    {
        public GreekSalad() : base("Greek salad")
        {

        }

        public override int GetCost()
        {
            return 50;
        }
    }
}