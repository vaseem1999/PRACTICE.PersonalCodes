using System;

namespace Coding.Exercise
{
  public class Exercise
  {
    public static int PrintSum(int a, int b)
    {
      return a + b;

    }
    static void Main()
    {
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(PrintSum(a, b));
    }
  }
}
