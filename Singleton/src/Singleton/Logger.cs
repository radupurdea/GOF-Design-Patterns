using System;
using System.Threading;

namespace Singleton
{
    public class Logger
    {
        private static Lazy<Logger> instance = new Lazy<Logger>(
            () => new Logger(), 
            LazyThreadSafetyMode.ExecutionAndPublication);

        private Logger()
        {
        }
        
        public static Logger Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("Logged: {0}", message);
        }
    }
}
