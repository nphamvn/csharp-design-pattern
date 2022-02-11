public sealed class Singleton
{
    private static int counter = 0;
    private static readonly object Instancelock = new object();
    private static Singleton instance = null;
    public static Singleton GetInstance
    {
        get
        {
            lock (Instancelock)
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
    private Singleton()
    {
        counter++;
        Console.WriteLine("Counter Value: " + counter);
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}