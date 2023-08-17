using System;
using System.Linq;
using System.Collections.Generic;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> list_a = new List<string>();
      list_a.Add("name_1");
      list_a.Add("name_2");
      list_a.Add("name_3");
      list_a.Add("name_4");
      list_a.Add("name_5");


      List<string> list_b = new List<string>();
      list_b.Add("Hyderabad");
      list_b.Add("Chennai");
      list_b.Add("Bangalore");
      list_b.Add("Kolkata");
      list_b.Add("Kerala");

      List<int> list_c = new List<int>(); 
      list_c.Add(10);
      list_c.Add(24);
      list_c.Add(45);
      list_c.Add(26);
      list_c.Add(37);

      List<string> new_list_a = new List<string>();

      for (int i = 0; i < list_b.Count; i += 2)
      {
        new_list_a.Add(list_b[i]);
      }
 
      List<string> new_list_b = new List<string>();

      for (int i = 1; i < list_b.Count; i += 2)
      {
        new_list_b.Add(list_b[i]);

      }
      List<string> result = new_list_a.Concat(new_list_b).ToList();

        for (int i =0; i < result.Count; i++) 
      {
        Console.WriteLine(list_a[i] + " is from "+ result[i] + ", He is " + list_c[i] + " Years Old") ;
      }
     

    }
  }
}