using System;
 
class Program
{
  static void Main(string[] args)
  {
    string[] array_a = { "name-1", "name-2", "name-3", "name-4", "name-5", "name-6", "name-7" };
    string[] array_b = { "Hyderabad", "Bangalore", "Chennai", "Kolkata", "Mumbai", "Delhi", "Gujarat" };
    int[] age = {24,26,24,32,12,25,41,20 };

    Random random = new Random();

    for (int i = 0; i < array_a.Length; i++)
    {
      int randomIndex = random.Next(array_a.Length); 
      Console.WriteLine(array_a[i] + " is from " + array_b[randomIndex] + ". I am " + age[i] + " years old");
    }
  }
}
