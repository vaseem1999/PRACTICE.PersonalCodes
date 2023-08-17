using System;
using System.Linq;

namespace Practice 
{
  class Program
  {
    static double Percentage(double num) 
    {
      if (num < 1000)
      {
        double a = (5.0/100) * num;
        return a;
      }
      else 
      {
        double b = (10.0/ 100) * num;
        return b;
      }
    
    }
    static void Main(string[] args) 
    {
      int number = Convert.ToInt32(Console.ReadLine());
      double result = Percentage(number);
      Console.WriteLine(result);
    }
  }
}