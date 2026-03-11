using System.Diagnostics.Metrics;

short counter = 1;     //Ввів лічільник
Console.WriteLine($"Hello! Type information for order {counter}: ");  // Інформація по першому клієнту
Console.WriteLine();

Console.Write("Client's name: ");                  //Блок введення інформації
string? clientName = Console.ReadLine();
Console.Write($"Product's name: ");
string? productName = Console.ReadLine();
Console.Write($"Product's price: ");
double? productPrice = Convert.ToDouble(Console.ReadLine());
Console.Write($"Client's address: ");
string? clientAddress = Console.ReadLine();

Console.WriteLine();                              //Блок виведення інформації
Console.WriteLine($"Order No {counter}");
Console.WriteLine($"Client: {clientName}.");
Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
Console.WriteLine($"Address: {clientAddress}.");
Console.WriteLine();

counter++;       //Збільшення лічільника на 1

Console.WriteLine($"Type information for order {counter}: ");  // Інформація по другому клієнту
Console.WriteLine();
Console.Write("Client's name: ");                             //Блок введення інформації
clientName = Console.ReadLine();
Console.Write($"Product's name: ");
productName = Console.ReadLine();
Console.Write($"Product's price: ");
productPrice = Convert.ToDouble(Console.ReadLine());
Console.Write($"Client's address: ");
clientAddress = Console.ReadLine();

Console.WriteLine();                                           //Блок виведення інформації
Console.WriteLine($"Order No {counter}");                     
Console.WriteLine($"Client: {clientName}.");
Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
Console.WriteLine($"Address: {clientAddress}.");
Console.WriteLine();

counter++;       //Збільшення лічільника на 1

Console.WriteLine($"Type information for order {counter}: ");  // Інформація по третьому клієнту
Console.WriteLine();
Console.Write("Client's name: ");                             //Блок введення інформації
clientName = Console.ReadLine();
Console.Write($"Product's name: ");
productName = Console.ReadLine();
Console.Write($"Product's price: ");
productPrice = Convert.ToDouble(Console.ReadLine());
Console.Write($"Client's address: ");
clientAddress = Console.ReadLine();

Console.WriteLine();                                           //Блок виведення інформації
Console.WriteLine($"Order No {counter}");
Console.WriteLine($"Client: {clientName}.");
Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
Console.WriteLine($"Address: {clientAddress}.");






