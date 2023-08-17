using System;

namespace JaggedArray 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      Dictionary<int,string> myDict = new Dictionary<int, string>();
      myDict.Add(1,"Vaseem");
      myDict.Add(2, "Vaseem");
      myDict.Add(3, "Vaseem");
      myDict.Add(4, "Vaseem");
      myDict.Add(5, "Vaseem");

      foreach (var item in myDict) 
      {
        Console.WriteLine(item);
      }

      List<string> list_a = new List<string>();
      list_a.Add("VAseem");
      list_a.Add("VAseem");
      list_a.Add("VAseem");
      list_a.Add("VAseem");

      foreach (var item in list_a)
      {
        Console.WriteLine("List: " + item);
      }
    }
  }
}
