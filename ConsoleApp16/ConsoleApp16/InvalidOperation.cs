using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class InvalidOperation
    {
        public static void Test()
        { 
        try
      {
        var accounts = new List<Account>() {
          new Account("Jimmy Gradle", 900),
          new Account("Sophie Gradle", 300)
        };

        Console.WriteLine("Looping through available accounts");

        foreach (Account account in accounts)
        {
          Console.WriteLine("{0} has {1} dollars", account.Name, account.Balance);
          if (account.Name == "Sophie Gradle")
          {
            var newAccount = new Account("Jeremy brown", 1500);
        Console.WriteLine("Adding {0} to the collection...\n", newAccount.Name);
            accounts.Add(newAccount);
          }
}
      }
      catch (InvalidOperationException ex)
{
    Console.WriteLine("Oh no, Something went wrong");
    Console.WriteLine(ex.Message);
}
    }

    class Account
{
    public Account(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }

    public string Name { get; private set; }
    public int Balance { get; private set; }
}
  }
}
    

