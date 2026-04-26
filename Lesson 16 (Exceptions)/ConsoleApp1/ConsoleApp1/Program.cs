//Напишіть програму, яка ділить два числа, введені користувачем.
//Якщо користувач вводить 0 як дільник, виведіть повідомлення про помилку.

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//decimal a = 0;
//decimal b = 0;
//decimal result = 0;
//while (true)
//{
//    Console.Write("Введіть ділене: ");
//    if (decimal.TryParse(Console.ReadLine(), out a))
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Ви ввели не число. Спробуйте ще раз: ");
//    }
//}
//while (true)
//{
//    Console.Write("Введіть дільник: ");
//    if (decimal.TryParse(Console.ReadLine(), out b))
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Ви ввели не число. Спробуйте ще раз: ");
//    }
//}
//try
//{
//    result = a / b;
//    Console.WriteLine($"{a} / {b} = {result}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Помилка! Ділення на 0 неможливе");
//}



//Напишіть програму, яка зчитує число з рядка. Якщо введене значення не є числом, виведіть повідомлення про помилку

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal a = 0;
Console.Write("Введіть число: ");
try
{
    string? input = Console.ReadLine();
    a = decimal.Parse(input);
    Console.WriteLine($"Ви ввели число: {a}");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Помилка! Введене число не може бути null");
}
catch (FormatException)
{
    Console.WriteLine("Помилка! Ви ввели  число: ");
}