using System;
using System.Linq;

namespace Program 
{
  class car 
  {
    public string name;
    public string color;
    public int price;
    public void PrintCarModel() 
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Color: " + color);
      Console.WriteLine("Price: " + price);
    }
  }
  class Progrma 
  {
    static void Main(string[] arg) 
    {
      car Honda = new car();
      Console.WriteLine("Car Name: ");
      Honda.name = Console.ReadLine();
      Console.WriteLine("Car Color: ");
      Honda.color = Console.ReadLine();
      Console.WriteLine("Car Color: ");
      Honda.price = Convert.ToInt32(Console.ReadLine());
      Honda.PrintCarModel();

    }
  }
}