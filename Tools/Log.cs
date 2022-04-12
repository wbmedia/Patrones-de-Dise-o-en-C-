using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;

        private string _path;

        // si se trabaja con hilos usemos este truco
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            // Evitamos o protejemos la instancia si trabajamos con hilos
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}

