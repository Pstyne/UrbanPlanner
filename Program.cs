using System;

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

      Console.WriteLine($@"
        {FiveOneTwoEigth.GetAddress()}
        ---------------
        Designed By {FiveOneTwoEigth.GetDesigner()}
        Constructed on {FiveOneTwoEigth.GetConstructionDate()}
        Owned By {FiveOneTwoEigth.GetOwner()}
        {FiveOneTwoEigth.Volume} cubic meters of space
      ");
    }
  }
}
