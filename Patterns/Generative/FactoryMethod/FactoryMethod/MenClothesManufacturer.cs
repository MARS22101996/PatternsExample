namespace FactoryMethod
{
    public class MenClothesManufacturer : ClothesManufacturer
    {
        public MenClothesManufacturer(string name) : base(name)
        {
        }

        public override Clothes Create()
        {
            return new MenClothes();
        }
    }
}
