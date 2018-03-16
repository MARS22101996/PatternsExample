namespace Singleton
{
    public class Computer
    {
        public FaceBookPage FaceBookPage { get; set; }

        public void Launch(string name)
        {
            FaceBookPage = FaceBookPage.GetInstance();
            FaceBookPage.Name = name;
        }
    }
}
