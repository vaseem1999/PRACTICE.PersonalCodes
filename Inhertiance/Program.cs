using System;
using System.Linq;
using System.Collections;

namespace practice
{
  class animal
  {
    public string name;
    public int height;
    public string type;
    public void Print_properties()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Height: " + height);
      Console.WriteLine("Type: " + type);
    }
  }

  class animal_nature:animal
  {
    public string threat;
    public void nature_of_animal() 
    {
      Console.WriteLine("Threat: " + threat);
    }
  }


  class wild_animal:animal_nature
  {
    public int speed;
    public string furr;
    public string growth_time;

    public void print_extam_props()
    {
      Console.WriteLine("Speed: " + speed);
      Console.WriteLine("furr: " + furr);
      Console.WriteLine("Growing Period: " + growth_time);
    }
  }
 
  class Program 
  {
    public static void Main(string[] args) 
    {
      wild_animal dog = new wild_animal();
      dog.name = "Labrador Retriever";
      dog.height = 4;
      dog.type = "domestic animal";
      dog.speed = 5;
      dog.furr = "Thick";
      dog.growth_time = "2 weeks";
      dog.threat = "Not dangerous";
      dog.Print_properties();
      dog.print_extam_props();
      dog.nature_of_animal();

      Console.ReadLine();

      wild_animal fox = new wild_animal();
      fox.name = "Fire Fox";
      fox.height = 4;
      fox.type = "Wild Animal";
      fox.speed = 5;
      fox.furr = "No Furr";
      fox.growth_time = "unknown";
      fox.threat = "dangerous";
      fox.Print_properties();
      fox.print_extam_props();
      fox.nature_of_animal();
    }
  }
}
