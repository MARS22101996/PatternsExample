namespace StructurePatterns
{
    public class SouceSalad : SaladDecorator
    {
        public SouceSalad(Salad salad) : base(salad.Name + "with souce ", salad)
        {

        }

        public override int GetCost()
        {
            return Salad.GetCost() + 10;
        }
    }
}
