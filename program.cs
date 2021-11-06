using System;

namespace dt171g_moment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Dagens datum är: {currentDate:d}");
            Console.WriteLine($"{Environment.NewLine}Klockan är: {currentDate:t}");
            Console.WriteLine($"{Environment.NewLine}Ha en bra dag {name}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
