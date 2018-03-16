namespace FactoryMethod
{
    public class WomenClothesManufacturer : ClothesManufacturer
    {
        public WomenClothesManufacturer(string name) : base(name)
        {
        }

        public override Clothes Create()
        {
            return new WomenClothes();
        }
    }
}
