using System;
using System.Linq;



namespace Practice 
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> ints = new List<int> {1,10,5,98,45,43,10};
      ints.Sort((ints1,ints2) => ints1.CompareTo(ints2));
      foreach (int i in ints) 
      {
        Console.WriteLine(i);
      }
     
      
    }
  }
}