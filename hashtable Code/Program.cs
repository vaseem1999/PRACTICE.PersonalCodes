using System;
using System.Collections;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable personNames = new Hashtable();
      personNames.Add("name_1", "P1");
      personNames.Add("name_2", "P2");
      personNames.Add("name_3", "P3");
      personNames.Add("name_4", "P4");
      personNames.Add("name_5", "P5");

      Hashtable cityNames = new Hashtable();
      cityNames.Add("name_1", "Hyderabad");
      cityNames.Add("name_2", "Bangalore");
      cityNames.Add("name_3", "Chennai");
      cityNames.Add("name_4", "Rajastan");
      cityNames.Add("name_5", "Mumbai");

      Hashtable ages = new Hashtable();
      ages.Add("name_1", 30);
      ages.Add("name_2", 25);
      ages.Add("name_3", 40);
      ages.Add("name_4", 28);
      ages.Add("name_5", 35);

      foreach (string key in personNames.Keys)
      {
        string personName = (string) personNames[key];
        string city = (string)cityNames[key];
        int age = (int)ages[key];

        Console.WriteLine(personName + " is from " + city + ", He is " + age + " years old.");
      }
    }
  }
}

