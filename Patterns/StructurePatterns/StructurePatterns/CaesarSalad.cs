namespace StructurePatterns
{
    public class CaesarSalad : Salad
    {
        public CaesarSalad() : base("Caesar salad")
        {
        }

        public override int GetCost()
        {
            return 100;
        }
    }
}