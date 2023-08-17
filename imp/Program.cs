using System;

class Program
{
  static void Main()
  {
    string[] names = new string[4];
    string[] cities = new string[4];

   // Console.WriteLine("Enter 10 name-city pairs:");

    for (int i = 0; i < 4; i++)
    {
      Console.Write($"Enter name-{i + 1}: ");
      names[i] = Console.ReadLine();

      Console.Write($"Enter city-{(char)('a' + i)}: ");
      cities[i] = Console.ReadLine();
    }

    Console.WriteLine("\nUser input values:");
    for (int i = 0; i < 4; i++)
    {
      Console.WriteLine($"Name-{i + 1}: {names[i]}, City-{(char)('a' + i)}: {cities[i]}");
    }
  }
}
