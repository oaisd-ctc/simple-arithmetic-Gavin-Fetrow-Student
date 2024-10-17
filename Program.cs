using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide a number to perform the addition operation.");
        string number = Console.ReadLine();
        Console.WriteLine(number + "... alright. Provide a number to add to " + number + ".");
        string secondNumber = Console.ReadLine();
        Console.WriteLine(secondNumber + ", ok then! Pretty simple. " + number + " + " + secondNumber + " is " + number + secondNumber);
    }
}