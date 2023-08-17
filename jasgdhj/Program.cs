using System;
using System.Collections;

namespace Practice
{
  class Program
  {

    public static void Person_method(Hashtable person)
    {
      string name = person["name"].ToString();
      string city = person["city"].ToString();
      int age = (int)person["age"];
      Console.WriteLine(name + " is from " + city + ", He is " + age + " Years Old.");

    }

    static void Main(string[] args) 
    {
      Hashtable person_one = new Hashtable();
      person_one.Add("name", "Name_1");
      person_one.Add("city","Hyderabad");
      person_one.Add("age", 24);
      Person_method(person_one);

      Hashtable Person_two = new Hashtable();
      Person_two.Add("name","Name-2");
      Person_two.Add("city", "Bangalore");
      Person_two.Add("age", 28);
      Person_method( Person_two);

      Hashtable Person_three = new Hashtable();
      Person_three.Add("name","Name-3");
      Person_three.Add("city","Chennai");
      Person_three.Add("age",45);
      Person_method(Person_three);
    }

   
  }
}
