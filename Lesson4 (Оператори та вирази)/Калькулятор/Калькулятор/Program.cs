// Калькулятор

decimal result;

Console.WriteLine("Hello! Type the first number: ");
string? firstNumber = Console.ReadLine();

if (decimal.TryParse(firstNumber, out decimal validFirstNumber))
{
    Console.WriteLine("Type the mathematical operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    Console.WriteLine("Type the second number: ");
    string? secondNumber = Console.ReadLine();

    if (decimal.TryParse(secondNumber, out decimal validSecondNumber))
    {
        switch (operation)
        {
            case "+":
                result = validFirstNumber + validSecondNumber;
                break;

            case "-":
                result = validFirstNumber - validSecondNumber;
                break;

            case "*":
                result = validFirstNumber * validSecondNumber;
                break;

            case "/":
                if (validSecondNumber == 0)
                {
                    Console.WriteLine("The operation is impossible. You cannot divide by zero"); // Перевірка ділення на 0
                    return; 
                }
                else
                {
                    result = validFirstNumber / validSecondNumber; 
                }
                break;

            default:
                Console.WriteLine("Unknown operation");
                return;
        }
        Console.WriteLine($"Result is: {result}");
    }
    else
    {
        Console.WriteLine("You didn't type a number");
    }
}
else
{
    Console.WriteLine("You didn't type a number");
}

