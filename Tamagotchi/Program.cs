using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {

        Tamagotchi tama = new Tamagotchi();


        Dictionary<string, Action> menu = new Dictionary<string, Action>();

        menu.Add("1", tama.Feed);
        menu.Add(
            "2",
            () =>
            {
                Console.WriteLine("What word would you like to teach me?");
                string word = Console.ReadLine();
                tama.Teach(word);
            }
        );
        menu.Add("3", tama.Hi);
        menu.Add("4", tama.PrintStats);

        while (tama.GetAlive())
        {
            tama.Tick();
            Console.WriteLine("Choose an action:\n1: Feed me\n2: Teach me a word\n3: I'll say a word you've learnt me\n4: Wanna see my stats? ;)");
            string input = Console.ReadLine();

            if (menu.ContainsKey(input))
                menu[input]();
            else
                Console.WriteLine("invalid");
            Console.ReadKey();
            Console.Clear();
        }
    }
}