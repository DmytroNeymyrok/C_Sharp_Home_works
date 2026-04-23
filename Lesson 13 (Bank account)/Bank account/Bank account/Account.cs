
//1.Створіть окремий проект.

//2.Створіть новий клас Account, що буде означати банківський рахунок. Кожен рахунок має свою назву та початкову сумму грошей на рахунку.
//Стан рахунку не може бути менше за 0. Реалізувати можливість додавати гроші на рахунок та віднімати гроші з рахунку.
//Реалізувати можливість отримати поточний стан рахунку, але не змінювати його напряму.

//3. Робота з рахунком повинна мати приблизно такий вигляд:


//Account heikkisAccount = new Account("Heikki's account", 100.00);
//Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);


//heikkisAccount.Withdrawal(20);
//Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);
//heikkisSwissAccount.Deposit(200);
//Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);

//23.04.2026
using Bank_account;

public class Account
{
    public Account (string name)
    {
        Name = name;    
    }
    public string Name { get; }

    public List<Transaction> Transactions { get; } = new List<Transaction> ();  

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be positive");
        }
            

        Transaction newTransaction = new Transaction(amount, TransactionKind.Deposit);
        Transactions.Add(newTransaction);
    }

    public void Withdraval(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be positive");
        }            

        if (GetBalance() - amount < 0)
        {
            throw new InvalidOperationException("Недостатньо коштів на рахунку");
        }            

        Transaction newTransaction = new Transaction (amount, TransactionKind.Withdraval);
        Transactions.Add(newTransaction);
    }

    public decimal GetBalance()
    {
        return Transactions.Sum(t => t.Kind == TransactionKind.Deposit? t.Amount : -t.Amount);
    }
}





//class BankApplication
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        bool isRunning = true;
//        while (isRunning)
//        {
//            Console.WriteLine("\n--- Яку дію хочете виконати? ---");
//            Console.WriteLine("1. Перевірити баланс");
//            Console.WriteLine("2. Поповнити баланс");
//            Console.WriteLine("3. Зняти гроші з рахунку");
//            Console.WriteLine("4. Вихід");
//            Console.Write("Виберіть дію: ");

//            string? choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    GetBalance();
//                    Console.WriteLine($"Поточний баланс: {GetBalanse.balance}");
//                    break;
//                case "2":
//                    ShowTasks();
//                    break;
//                case "3":
//                    CompleteTask();
//                    break;
//                case "4":
//                    Console.WriteLine("Програма завершена");
//                    isRunning = false;
//                    break;
//                default:           // Обробка помилок (якщо введено щось інше)
//                    Console.WriteLine("Помилка: Невірний вибір. Спробуйте ще раз (1-4)");
//                    break;
//            }
//        }
//    }


    //class Account
    //{
    //    public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    //    public decimal GetBalance()
    //    {
    //        decimal balance = 0;
    //        foreach (var transaction in Transactions)
    //        {
    //            if (transaction.Type == TransactionType.Deposit)
    //            {
    //                balance += transaction.Amount;
    //            }
    //            else if (transaction.Type == TransactionType.Withdraval)
    //            {
    //                balance -= transaction.Amount;
    //            }
    //        }
    //        return balance;
    //    }

    //}

//    class Account
//    {
//        private string name;
//        private decimal balance;
//        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
//        public decimal GetBalance()
//        {
//            decimal balance = 0;
//            foreach (var transaction in Transactions)
//            {
//                if (transaction.Type == TransactionType.Deposit)
//                {
//                    balance += transaction.Amount;
//                }
//                else if (transaction.Type == TransactionType.Withdraval)
//                {
//                    balance -= transaction.Amount;
//                }
//            }
//            return balance;
//        }

//    }

//    class Transaction
//    {
//        public decimal Amount { get; set; }
//        public TransactionType Type { get; set; }
//    }

//    enum TransactionType
//    {
//        Deposit,
//        Withdraval
//    }


//}

//Версія ШІ

//using System;
//using System.Collections.Generic;

//class BankApplication
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        // Список для зберігання всіх рахунків
//        List<Account> accounts = new List<Account>();

//        // Додамо кілька рахунків для старту, як у прикладі
//        accounts.Add(new Account("Heikki's account", 100.00));
//        accounts.Add(new Account("Heikki's account in Switzerland", 1000000.00));

//        bool isRunning = true;
//        while (isRunning)
//        {
//            Console.WriteLine("\n--- МЕНЮ ---");
//            Console.WriteLine("1. Список усіх рахунків та баланс");
//            Console.WriteLine("2. Створити новий рахунок");
//            Console.WriteLine("3. Вибрати рахунок для операцій (Поповнення/Зняття)");
//            Console.WriteLine("4. Вихід");
//            Console.Write("Виберіть дію: ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.WriteLine("\nВаші рахунки:");
//                    foreach (var acc in accounts)
//                    {
//                        Console.WriteLine($"- {acc.Name}: {acc.Balance:F2}");
//                    }
//                    break;

//                case "2":
//                    Console.Write("Введіть назву нового рахунку: ");
//                    string name = Console.ReadLine();
//                    Console.Write("Введіть початковий баланс: ");
//                    if (double.TryParse(Console.ReadLine(), out double initialBalance))
//                    {
//                        accounts.Add(new Account(name, initialBalance));
//                        Console.WriteLine("Рахунок успішно створено!");
//                    }
//                    break;

//                case "3":
//                    ManageAccount(accounts);
//                    break;

//                case "4":
//                    isRunning = false;
//                    break;
//            }
//        }
//    }

//    // Окремий метод для роботи з конкретним рахунком
//    static void ManageAccount(List<Account> accounts)
//    {
//        if (accounts.Count == 0) { Console.WriteLine("Список рахунків порожній."); return; }

//        Console.WriteLine("\nОберіть номер рахунку:");
//        for (int i = 0; i < accounts.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {accounts[i].Name}");
//        }

//        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= accounts.Count)
//        {
//            Account selected = accounts[index - 1];
//            Console.WriteLine($"\nВибрано: {selected.Name}. (1 - Поповнити, 2 - Зняти)");
//            string action = Console.ReadLine();

//            if (action == "1")
//            {
//                Console.Write("Сума поповнення: ");
//                if (double.TryParse(Console.ReadLine(), out double amount)) selected.Deposit(amount);
//            }
//            else if (action == "2")
//            {
//                Console.Write("Сума зняття: ");
//                if (double.TryParse(Console.ReadLine(), out double amount)) selected.Withdrawal(amount);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Невірний номер.");
//        }
//    }

//    class Account
//    {
//        private string name;
//        private double balance;

//        public string Name => name;
//        public double Balance => balance;

//        public Account(string accountName, double initialBalance)
//        {
//            name = accountName;
//            balance = initialBalance < 0 ? 0 : initialBalance;
//        }

//        public void Deposit(double amount)
//        {
//            if (amount > 0) balance += amount;
//        }

//        public void Withdrawal(double amount)
//        {
//            if (amount > 0 && balance >= amount)
//            {
//                balance -= amount;
//                Console.WriteLine("Операція успішна.");
//            }
//            else
//            {
//                Console.WriteLine("Помилка: недостатньо коштів або невірна сума.");
//            }
//        }
//    }
//}



//class Account
//{
//    public List<Transaction> Transactions { get; set; } = new List<Transaction>();
//    public decimal GetBalance()
//    {
//        decimal balance = 0;
//        foreach (var transaction in Transactions)
//        {
//            if (transaction.Type == TransactionType.Deposit)
//            {
//                balance += transaction.Amount;
//            }
//            else if (transaction.Type == TransactionType.Withdraval)
//            {
//                balance -= transaction.Amount;
//            }
//        }
//        return balance;
//    }

//}

//class Transaction
//{
//    public decimal Amount {  get; set; }
//    public TransactionType Type{  get; set; }
//}

//enum TransactionType
//{
//    Deposit,
//    Withdraval
//}