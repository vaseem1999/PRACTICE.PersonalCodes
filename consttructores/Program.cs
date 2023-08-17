using System;
using System.Linq;

namespace Constructors 
{
  class Car
  {
    public string name;
    public string color;
    public int year;
    public Car(string carName, string carColor, int carYear)
    {
      name = carName;
      color = carColor;
      year = carYear;
    }

    static void Main(string[] args) 
    {
      Car obj = new Car("Audi", "Black", 2020);
      Car obj2 = new Car("Beanz","Red",2023);
      Console.WriteLine(obj.name + " " + obj.color + " " + obj.year);
      Console.WriteLine(obj2.name + " " + obj2.color + " " + obj2.year);
    }
  }
  
}
