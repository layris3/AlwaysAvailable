namespace AlwaysAvailable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runForever = false;
            int hour = 0;
            int min = 0;
            Console.WriteLine("please enter an hour, or enter 'n' to always run.");
            String hourStr = Console.ReadLine();
            if (hourStr == "n" || hourStr == "N")
                runForever = true;
            else
            {
                Console.WriteLine("please enter the mininute.");
                String minStr = Console.ReadLine();
                try
                {
                    hour = int.Parse(hourStr);
                    min = int.Parse(minStr);
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid hour and minute,exiting...");
                    throw;
                }
            }

            while (true)
            {
                Keyboard.KeyUp(131);
                Thread.Sleep(1000);
                if (!runForever && DateTime.Now.Hour >= hour && DateTime.Now.Minute >= min)
                {
                    break;
                }
            }

        }
    }
}