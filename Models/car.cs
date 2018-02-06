using System.Collections.Generic;
using System;


namespace Dealership.Models
{
  public class Car
  {
    private string _description;
    private string _miles;
    private static List<Car> _instances = new List<Car> {};

    public Car (string description, string miles)
    {
      _description = description;
      _miles = miles;
    }
    public string GetDescription()
    {
      return _description;
    }
    public string GetMiles()
    {
      return _miles;
    }
    public void SetDescription (string newDescription)
    {
      _description = newDescription;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
