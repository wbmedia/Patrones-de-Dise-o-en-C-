namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;

            var log = Log.Instance;
            log.Save("Jose Antonio Nicasio Herrera");
            log.Save("Joan Danniels Jacobs");
        }
    }
}

