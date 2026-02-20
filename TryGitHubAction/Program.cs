namespace TryGitHubAction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET!");
            int result = Add(5, 7);
            Console.WriteLine($"5 + 7 = {result}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}