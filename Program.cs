namespace AlwaysAvailable
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Keyboard.KeyUp(131);
                Thread.Sleep(1000);
            }

        }
    }
}