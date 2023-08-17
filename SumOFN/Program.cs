using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
  internal class Class1
  {
    static int Sum_of_n(int n)
    {
    
      int sum = 0;
      for (int i = 0; i <= n; i++)
      {
        sum += i;
      }
      return sum;
    }
    static void Main()
    {
      int m = Convert.ToInt32(Console.ReadLine());
      int result = Sum_of_n(m);

      Console.WriteLine(result);
    }
  }
}
