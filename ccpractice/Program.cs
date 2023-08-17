using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Practice
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list_a = new List<string> { };
      list_a.Add("Vaseem");
      list_a.Add("Venu");
      list_a.Add("Naveen");
      list_a.Add("Akhil");

      foreach (string name in list_a) 
      {
        Console.WriteLine(name);
      }
    }
  }
}
