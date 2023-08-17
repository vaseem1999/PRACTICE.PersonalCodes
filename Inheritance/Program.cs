using System;
using System.Collections.Generic;

namespace Method 
{
  class Program 
  {
    public void Sum(int a,int b) 
    {
      Console.WriteLine(a + b);
    }
    public void Sum(float a, int b)
    {
      Console.WriteLine(a + b);
    }
    public static void Main(string[] args) 
    {
      Program onj = new Program();
      onj.Sum(1,2);
      onj.Sum(5.2f,2);
    }
  }
}
