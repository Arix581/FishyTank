// A program for my mom to calculate fishtank stuff
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello! My name is Fishy Watersolver 1.4. \nMy purpose is to perform a function that tells you how \nmuch water you need in your fishtank. To start, just \ntype how many degrees your cold water is.");
        
        for (int i = 0; i < 50; i++) {
            float z = Convert.ToSingle(Console.ReadLine());
            float x = (750 - (10 * z))/125;
            Console.WriteLine("Well, you need " + x + " kettles of 200 degree water for every 5 gallon water change." );
            Console.WriteLine("Anything else? Enter another temperature to continue...");

        }
    }
}
