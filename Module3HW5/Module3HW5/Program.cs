namespace Module3HW5
{
    public class Program
    {
        public static void Main()
        {
            AsyncMethods asyncMethods = new AsyncMethods();
            string helloWorld = asyncMethods.GetHelloWorldTextAsync().Result;

            Console.WriteLine(helloWorld);
        }
    }
}