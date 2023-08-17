using System;
using System.Linq;

namespace Objects_classe 
{
  class car
  {
    public string name;
    public string color;
    public int price;

    public void printCarModel()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Color: " + color);
      Console.WriteLine("Price: " + price);
      Console.ReadLine();
    }
  }

  class Fruit
  {
    public string name;
    public int qunatity;
    public int price;
    public void Print_Totl_Price()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Color: " + qunatity);
      Console.WriteLine("Price: " + price);
    }
  }

  class calculator 
  {
    public int num1;
    public int num2;
    public int result;
    public void adition() 
    {
      result = num1 + num2;
      Console.WriteLine("Addition = " + result);
    }
    public void sub() 
    {
      result = num1 - num2;
      Console.WriteLine("subtraction = " + result);
    }
  }


  class Program
  {
    public static void Main(string[] args) 
    {
      car volvo = new car();
      volvo.name = "Volvo Xml";
      volvo.color = "red";
      volvo.price = 1500000;
      //volvo.printCarModel();

      Fruit apple = new Fruit();
      apple.name = "Apple";
      apple.qunatity = 30;
      apple.price = 50;
      //apple.Print_Totl_Price();

      calculator obj = new calculator();
      Console.WriteLine("Enter num1 here:");
      obj.num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter num2 here:");
      obj.num2 = Convert.ToInt32(Console.ReadLine());
      obj.adition();
      obj.sub();

    }
  }

}