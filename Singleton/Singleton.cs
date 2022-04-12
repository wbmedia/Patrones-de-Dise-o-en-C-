namespace Singleton
{
    public class Singleton
    {
        /// <summary>
        /// The Singleton Base
        /// </summary>

        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private Singleton()
        {

        }
    }
}

