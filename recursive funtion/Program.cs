using System;
using System.Linq;

namespace recurrsion 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter Number Here: ");
      int number = Convert.ToInt32(Console.ReadLine());
      double result = Factorial(number);
      Console.WriteLine(result);
    }
    static double Factorial(int n) 
    {
      if (n == 0)
      {
        return 1;
      }
      else 
      {
        return n * Factorial(n-1);
      }
    }
  }
}