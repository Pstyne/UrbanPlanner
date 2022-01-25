using System;

namespace Planner {
  class Building {
    private string _designer = "Andy";
    private DateTime _dateConstructed;

    private string _owner;
    private string _address;

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume 
    {
      get
      {
        //* Each story is 3 meters high. 
        return this.Width * this.Depth * (3 * this.Stories);
      }
    }

    public Building (string address)
    {
      _address = address;
    }

    public void Construct ()
    {
      _dateConstructed = DateTime.Now; 
    }

    public void Purchase (string owner)
    {
      _owner = owner;
    }

    public string GetDesigner()
    {
      return _designer;
    }
    public DateTime GetConstructionDate()
    {
      return _dateConstructed;
    }
    public string GetOwner()
    {
      return _owner;
    }

    public string GetAddress()
    {
      return _address;
    }

  }
}