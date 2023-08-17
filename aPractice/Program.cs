using System;
using System.Linq;
using System.Text;

namespace aPractice 
{
  class program
  {
    static void Main(string[] args)
    {
      string name = Console.ReadLine();
      StringBuilder rev_name = new StringBuilder();
      int length = name.Length;
      for (int i = 1; i <= length; i++)
      {
        rev_name.Append(name[length - i]);
      }
      //Console.WriteLine(rev_name);
      if (name == rev_name.ToString())
      {
        Console.WriteLine("True");
      }
      else 
      {
        Console.WriteLine("False");
      }

    }
  }
}
