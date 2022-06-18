namespace Module3HW5
{
    public class AsyncMethods
    {
        private readonly string path = "C:\\Users\\sasha\\source\\repos\\Module3HW5\\Module3HW5\\Module3HW5\\files";

        private async Task<string> GetHelloFromFileAsync()
        {
            string hello = await File.ReadAllTextAsync(path + "\\hello.txt");

            return hello;
        }

        private async Task<string> GetWorldFromFileAsync()
        {
            string world = await File.ReadAllTextAsync(path + "\\world.txt");

            return world;
        }

        public async Task<string> GetHelloWorldTextAsync()
        {
            string hello = await GetHelloFromFileAsync();
            string world = await GetWorldFromFileAsync();

            return $"{hello} {world}";
        }
    }
}
