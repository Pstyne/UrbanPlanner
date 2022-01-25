using System.Collections.Generic;

namespace Planner
{
  class City
  {
    private string _name;
    private string _mayorName;
    private int _yearEstablished;
    public List<Building> Buildings = new List<Building>();

    public void AddBuilding(Building building)
    {
      Buildings.Add(building);
    }

    public City(string name)
    {
      _name = name;
    }

    public string CityName()
    {
      return _name;
    }

    public void SetMayorName(string mayorName)
    {
      _mayorName = mayorName;
    }

    public string MayorName()
    {
      return _mayorName;
    }

    public void SetYearEstablished(int yearEstablished)
    {
      _yearEstablished = yearEstablished;
    }

    public int YearEstablished()
    {
      return _yearEstablished;
    }
  }
}