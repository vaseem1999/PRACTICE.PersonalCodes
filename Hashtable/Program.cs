using System;
using System.Collections;
using System.Linq;

namespace hasDict
{
  class Program 
  {
    static void Main(string[] args) 
    {
      Hashtable ht = new Hashtable();
      ht.Add("id", 01);
      ht.Add("name","Vaseem");
      ht.Add("Email", "vaseem213@gmail.com");
      ht.Add("number", 9515531131);
      foreach (object values in ht.Keys) 
      {
        Console.WriteLine(values);
      }
    }
  }
}