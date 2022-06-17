namespace Module3HW5
{
    public class Starter
    {
        public void Run()
        {
            AsyncMethods asyncMethods = new AsyncMethods();
            string helloWorld = asyncMethods.GetHelloWorldTextAsync().Result;

            Console.WriteLine(helloWorld);
        }
    }
}
