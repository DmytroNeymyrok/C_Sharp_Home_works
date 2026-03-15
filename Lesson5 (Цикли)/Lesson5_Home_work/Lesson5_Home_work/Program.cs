//1. Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.

Console.Write("Введіть кількість працівників: ");
byte employeeQuantity;
while (!byte.TryParse(Console.ReadLine(), out employeeQuantity) || employeeQuantity <= 0)
{
    Console.WriteLine("Кількість працівників має бути числом більше 0. Спробуйте ще раз");
}

decimal totalSalary = 0;
for (int i = 1; i <= employeeQuantity; i++)
{
    Console.Write($"Введіть зарплату {i}-го співробітника: ");
    decimal currentSalary;
    while (!decimal.TryParse(Console.ReadLine(), out currentSalary) || currentSalary <= 0)
    {
        Console.Write("Зарплата має бути числом більше 0. Спробуйте ще раз: ");
    }
    totalSalary += currentSalary;

}
decimal averageSalary = totalSalary / employeeQuantity;
decimal roundedAverageSalary = Math.Round(averageSalary, 2); //Додав заокруглення до 2 знаків після коми тільки для виводу на екран без зміни самого значення середньої зп
Console.WriteLine($"Середня зарплата: {roundedAverageSalary} грн.");


//----------------------------------------------------------------------------------------------------------------------------------------

//2. Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
//Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

/*
string line = "";
byte linesNumber = 0;
Console.Write("Введіть кількість рядків: ");

while (!byte.TryParse(Console.ReadLine(), out linesNumber))
{
    Console.WriteLine("Ви ввели не число. Спробуйте ще раз:");
}


    for (byte i=0; i<linesNumber; i++)
    {
        line += "*";
        Console.WriteLine(line); 
    }
    */


//----------------------------------------------------------------------------------------------------------------------------------------

//3. Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. Просте число - це число, яке ділиться лише на 1 і на себе.

/*
Console.Write("Enter your natural number > 1: ");
int userNumber;
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber <= 1)
{
    Console.Write("You have typed wrong number. Try again: ");
}

Console.WriteLine($"Prime numbers from 1 to {userNumber}: ");

for (int currentNumber = 2; currentNumber <= userNumber; currentNumber++)
{
    bool isPrime = true;
    for (int i = 2; i < currentNumber; i++)
    {
        if (currentNumber % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine($"{currentNumber} ");
    }
}
*/


//----------------------------------------------------------------------------------------------------------------------------------------

//4. Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі.
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

/*
Console.Write("Enter quantity of Fibonacci numbers: ");
int userNumber = 0;
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber <= 0)
{
    Console.Write("You have typed wrong number. Try again: ");
}
long a = 0;
long b = 1;
long c = 0;
int counter = 0;

Console.Write($"The first {userNumber} Fibonacci numbers are: ");

while (userNumber > 0 && counter < userNumber)
{
    Console.Write($"{a} ");
    c = a + b;
    a = b;
    b = c;
    counter++;
}
*/



//----------------------------------------------------------------------------------------------------------------------------------------

//5. Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день,
//та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.

/*

Console.Write("Enter hours number: ");
int hoursNumber;
while (!int.TryParse(Console.ReadLine(), out hoursNumber) || hoursNumber < 0)
{
    Console.Write("You have typed wrong number for hours number. Try again: ");
}
Console.Write("Enter hour salary: ");
decimal hourSalary;
while (!decimal.TryParse(Console.ReadLine(), out hourSalary) || hourSalary <= 0)
{
    Console.Write("You have typed wrong number for salary. Try again: ");
}
decimal totalSalary = hoursNumber * hourSalary;
Console.Write($"Total salary is: {totalSalary} UAH");

*/

//----------------------------------------------------------------------------------------------------------------------------------------

//6. Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

/*

Console.Write("Enter your number: ");
int userNumber;
while (!int.TryParse(Console.ReadLine(), out userNumber))
{
    Console.Write("You have typed wrong number. Try again: ");
}
int result;
for (int i = 1; i <= 10; i++)
{
    result = i* userNumber;
    Console.WriteLine($"{userNumber} * {i} = {result}");
}

*/

//----------------------------------------------------------------------------------------------------------------------------------------

//7. Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.

/*

Console.Write("Enter your natural number > 0: ");
int userNumber = 0;
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber <= 0)
{
    Console.Write("You have typed wrong number. Try again: ");
}
if (userNumber == 1)
{
    Console.WriteLine($"The number {userNumber} is not prime");
    return;
}
bool isPrime = true;
for (int i = 2; i < userNumber; i++)
{
    if (userNumber % i == 0)
    {
        isPrime = false;
        break;
    }
    else
    {
        isPrime = true;
    }
}
if (isPrime)
{
    Console.WriteLine($"The number {userNumber} is prime");
}
else
{
    Console.WriteLine($"The number {userNumber} is not prime");
}

*/

