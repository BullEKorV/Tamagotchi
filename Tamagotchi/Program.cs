using System;


class Program
{
    static void Main(string[] args)
    {
        Tamagotchi tama = new Tamagotchi();
        while (tama.GetAlive())
        {
            tama.Tick();
            Console.WriteLine("Choose an action:\n1: Feed me\n2: Teach me a word\n3: I'll say a word you've learnt me\n4: Wanna see my stats? ;)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "1":
                    Console.WriteLine("Thank you papi");
                    tama.Feed();
                    break;
                case "2":
                    Console.WriteLine("What word would you like to teach me?");
                    string word = Console.ReadLine();
                    tama.Teach(word);
                    break;
                case "3":
                    tama.Hi();
                    break;
                case "4":
                    tama.PrintStats();
                    break;
                default:
                    Console.WriteLine("You did nothing smh");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}