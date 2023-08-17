using System;
using System.Linq;
using System.Diagnostics.Tracing;

namespace MoreFunctions 
{
  class Program 
  {
    static int Count_the_vowels(string word ) 
    {
      int count = 0;
      foreach (char each_word in word) 
      {
        if (char.IsUpper(each_word)) 
        {
           count++;
        }
      }
      return count;
      
    }
    static void Main(string[] args) 
    {
      string inout_word = Console.ReadLine();
      int result = Count_the_vowels(inout_word);
      Console.WriteLine(result);
    }
  }
}