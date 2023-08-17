using System;
using System.Linq;

namespace arraysPractice 
{
  public class Program 
  {
    public static void Main(string[] args) 
    {
      int[,] array_a = new int[,]{ {0,1,2 },{ 5,6,4},{7,9,8 } };
      for (int i = 0; i < 3; i ++) 
      {
        for (int j = 0; j < 3; j++) 
        {
          Console.WriteLine(array_a[i,j]);
        }
      }
    }
  }
}