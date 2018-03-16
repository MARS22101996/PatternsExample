namespace StructurePatterns
{
    public abstract class SaladDecorator : Salad
    {
        protected Salad Salad;

        protected SaladDecorator(string name, Salad salad) : base(name)
        {
            Salad = salad;
        }
    }
}
