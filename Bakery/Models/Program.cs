using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  class Program
  {

    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");

      Console.WriteLine("Bread is $5 per loaf, with a buy 2 get 1 free promotion");

      Console.WriteLine("Pastries are $2 each, with a 3 for $5 promotion");

      Console.WriteLine("How many loaves of bread would you like?");
      string stringLoafOrder = Console.ReadLine();
      int intLoafOrder = int.Parse(stringLoafOrder);

      Console.WriteLine("How many pastries would you like?");
      string stringPastryOrder = Console.ReadLine();
      int intPastryOrder = int.Parse(stringPastryOrder);

      if (intLoafOrder % 2 == 0)
      {
        Console.WriteLine("You scored a deal on this bread!");
      }

      if (intPastryOrder % 3 == 0)
      {
         Console.WriteLine("Hooray for pastry deals!");
      }
    }

  }
}