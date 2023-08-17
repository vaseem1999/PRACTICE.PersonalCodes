using System;

namespace Encapsulation 
{
  class Account 
  {
    int accountBalance = 1000;
    public void SetBalance(int amount) 
    {
      if (amount < 0)
      {
        Console.WriteLine("Amount can not be in negative value");
      }
      else 
      {
        accountBalance = amount;
      }
    }
    public void GetBalance() 
    {
      Console.WriteLine("Your A/C balance is: " + accountBalance);
    }
  }
  class Program 
  {
    static void Main(string[] args) 
    {
      Account myAccount = new Account();
      myAccount.SetBalance(100000);
      myAccount.GetBalance();
    }
  }
}