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

    }
    public bool GetAlive()
    {
        return isAlive;
    }
    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine($"Succesfully added {word} to dictionary uwu");
    }
    public void Hi()
    {
        int index = rnd.Next(words.Count);
        Console.WriteLine(words[index]);
    }
    public void Feed()
    {

    }
    public void Tick()
    {

    }
    public void PrintStats()
    {
        Console.WriteLine("My name is" + name);
        Console.WriteLine($"I am {hunger} hungry uwu");
        Console.WriteLine("");
    }
    private void ReduceBoredom()
    {

    }
}