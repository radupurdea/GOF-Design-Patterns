namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger.Instance.Log("First!");
            Logger.Instance.Log("Second.");
        }
    }
}
