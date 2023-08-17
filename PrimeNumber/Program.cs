using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
  class Program
  {
    public static string Prime(int n)
    {
      string is_prime = " ";
      if (n > 1)
      {
        for (int i = 2; i < n; i++)
        {
          if (n % i == 0)
          {
            is_prime = n + " Not a prime number";
            break;
          }
          else
          {
            is_prime = n + " is a prime number";
          }
        }

      }
      else
      {
        is_prime = n + " is not a prime number";
      }
      return is_prime;
    }
   static void Main(string[] args) 

    {
      int m = Convert.ToInt32 (Console.ReadLine());
      string result = Prime(m);
      Console.WriteLine(result);
    }
  }
}
    
 

