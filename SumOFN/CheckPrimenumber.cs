using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
  class Program
  {
     static String isPrime(int n)
    {
      if (n > 1) 
      {
        for (int i = 2; i < n; i++)
        {
          if (n % i == 0)
          {
            Console.WriteLine("Num is not a prime number");
            break;
          }
          else 
          {
            Console.WriteLine("Num is a prime number");
          }
        
        }
      }
    }
    public static void Main(String[] args) 
    {
      int m = Convert.ToInt32(Console.ReadLine());
      isPrime(m);
      //Console.WriteLine(result);
    }
  }
}
