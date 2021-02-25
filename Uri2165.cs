using System;
class Uri
{
    static void Main(string[] args)
    {
        string twitter = Console.ReadLine();

        Console.WriteLine(twitter.Length <= 140 ? "TWEET" : "MUTE");
    }    
}