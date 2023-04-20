namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "hello world!";
            {
                foreach (char c in message)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                    Console.ResetColor();
                    
                    System.Threading.Thread.Sleep(100);
                }
            }

        }
    }
}