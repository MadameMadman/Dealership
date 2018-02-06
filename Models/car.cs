using System.Collections.Generic;
using System;


namespace Dealership.Models
{
  public class Car
  {
    private string _model;
    private string _miles;
    private string _description;
    private static List<Car> _instances = new List<Car> {};

    public Car (string model, string description, string miles)
    {
      _model = model;
      _miles = miles;
      _description = description;
    }
    public string GetModel()
    {
      return _model;
    }
    public string GetMiles()
    {
      return _miles;
    }
    public string GetDescription()
    {
      return _description;
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
