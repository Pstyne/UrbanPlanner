using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Building FiveOneTwoEigth = new Building("512 8th Avenue");
      FiveOneTwoEigth.Width = 100;
      FiveOneTwoEigth.Depth = 100;
      FiveOneTwoEigth.Stories = 12;
      FiveOneTwoEigth.Construct();
      FiveOneTwoEigth.Purchase("Bob Ross");

      Building OneTwoThree = new Building("123 Main Street");
      OneTwoThree.Width = 45;
      OneTwoThree.Depth = 56;
      OneTwoThree.Stories = 6;
      OneTwoThree.Construct();
      OneTwoThree.Purchase("Jim Bob");

      Building FourFiveSix = new Building("456 Plain Drive");
      FourFiveSix.Width = 65;
      FourFiveSix.Depth = 76;
      FourFiveSix.Stories = 7;
      FourFiveSix.Construct();
      FourFiveSix.Purchase("Sally Slappers");

      Building SevenEightNine = new Building("789 Lucky Avenue");
      SevenEightNine.Width = 77;
      SevenEightNine.Depth = 45;
      SevenEightNine.Stories = 5;
      SevenEightNine.Construct();
      SevenEightNine.Purchase("Kevin Smith");

      Building FourTwoZero = new Building("420 High Place");
      FourTwoZero.Width = 420;
      FourTwoZero.Depth = 333;
      FourTwoZero.Stories = 13;
      FourTwoZero.Construct();
      FourTwoZero.Purchase("Snoop Dogg");

      List<Building> buildings = new List<Building>()
      {
        FiveOneTwoEigth,
        OneTwoThree,
        FourFiveSix,
        SevenEightNine,
        FourTwoZero
      };

      foreach (Building building in buildings)
      {
        Console.WriteLine($@"
          {building.GetAddress()}
          ---------------
          Designed By {building.GetDesigner()}
          Constructed on {building.GetConstructionDate()}
          Owned By {building.GetOwner()}
          {building.Volume} cubic meters of space
        ");
      }

    }
  }
}
