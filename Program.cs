using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Pick a number for the computer to guess between 1 and 100");

      int MAX = 100;
      int MIN = 0;
      // loop....
      var input = "";
      while (input != "yes")
      {
        var guess = (MAX + MIN) / 2;


        //   if (MAX + MIN / 2 > int.Parse(input))
        //   {
        //     Console.WriteLine("computer guessed too high");
        //   }
        Console.WriteLine($"Is your number {guess}, or higher, or lower");
        input = Console.ReadLine();


        Console.WriteLine($"{MAX}, {MIN}, {guess}, {input}");
        if (input == "higher")
        {
          MIN = guess;
        }
        else if (input == "lower")
        {
          MAX = guess;
        }
      }
    }
  }
}
