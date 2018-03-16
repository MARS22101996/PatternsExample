namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var swimmer  = new Sportsman(new Swimmer());
            var runner = new Sportsman(new Runner());
            swimmer.Wear();
            runner.Wear();
            swimmer.Move();
            runner.Move();
        }
    }
}
