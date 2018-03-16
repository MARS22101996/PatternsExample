namespace StructurePatterns
{
    public abstract class Salad
    {
        public string Name { get; protected set; }
        public Salad(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }
}
