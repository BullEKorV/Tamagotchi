using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string name;
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private List<string> words = new List<string>() { "Uwu", "Kawaii" };
    private Random rnd = new Random();
    public Tamagotchi()
    {
        Console.WriteLine("Choose a name for me uwu: ");
        this.name = Console.ReadLine();
        Console.WriteLine(this.name + " it is ;)");
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine($"Succesfully added {word} to dictionary uwu");
        ReduceBoredom();
    }
    public void Hi()
    {
        int index = rnd.Next(words.Count);
        Console.WriteLine(words[index]);
        ReduceBoredom();
    }
    public void Feed()
    {
        hunger -= 4;
        hunger = Math.Max(0, hunger);
    }
    public void Tick()
    {
        boredom++;
        hunger++;
        if (hunger > 10 || boredom > 10)
            isAlive = false;
    }
    public void PrintStats()
    {
        Console.WriteLine("My name is" + name);
        Console.WriteLine($"I am {hunger}/10 hungry uwu");
        Console.WriteLine($"I am {boredom}/10 bored :(");
    }
    private void ReduceBoredom()
    {
        boredom -= 4;
        boredom = Math.Max(0, boredom);
    }
}