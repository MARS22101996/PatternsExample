namespace FactoryMethod
{
    public abstract class ClothesManufacturer
    {
        private string Name { get; set; }

        protected ClothesManufacturer(string name)
        {
            Name = name;
        }

        public abstract Clothes Create();
    }
}
