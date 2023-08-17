using Microsoft.VisualBasic;
using System.Runtime.ExceptionServices;

namespace Practice
{
  class Program
  {
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter you word: ");
      string word = Console.ReadLine();

      char first_word = word[0];
      char last_word = word[word.Length-1];
      //Console.WriteLine(first_word + " " + last_word);
      if (first_word == last_word) 
      {
        Console.WriteLine("False");
      }
      else 
      {
        Console.WriteLine("True");
      }
    }
  }
}