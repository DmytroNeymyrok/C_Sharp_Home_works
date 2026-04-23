using System;
using System.Collections.Generic;
using System.Text;
using Bank_account;

class Program
{
    static void Main()
    {
        Account account1 = new Account("First account");

        account1.Deposit(100);
        account1.Withdraval(30);
        account1.Deposit(50);

        Console.WriteLine($"Баланс рахунку {account1.Name}: {account1.GetBalance()}");

        Account account2 = new Account("Second account");

        account2.Deposit(80);
        account2.Withdraval(20);
        account2.Deposit(10);

        Console.WriteLine($"Баланс рахунку {account2.Name}: {account2.GetBalance()}");
    }
}

