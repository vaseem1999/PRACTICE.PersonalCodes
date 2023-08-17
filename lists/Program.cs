using System;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Collections;
using System.Security.Cryptography;

namespace ArraysList 
{
  class Program 
  {
    static void Main(string[] args)
    {
     ArrayList arrayList_a = new ArrayList();
      arrayList_a.Add(100);
      arrayList_a.Add(200);
      arrayList_a.Add(300);
      arrayList_a.Insert(3,400);
      
     arrayList_a.Remove(300);
      foreach (int item in arrayList_a)
        Console.Write(item + " ");

      string[] arrayList_b = new string[] { "vaseem", "Naveen", "Venu", "akhil" };
      arrayList_b[1] = "Puli";
      foreach (string item in arrayList_b) 
      {
        Console.Write(item + " ");
      }
    }
  }
}