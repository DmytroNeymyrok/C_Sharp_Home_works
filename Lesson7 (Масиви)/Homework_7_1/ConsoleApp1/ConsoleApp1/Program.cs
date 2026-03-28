//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10,
//використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
//Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)


int[] randomArray = new int[10];
Random currentValue = new Random();
Console.Write("All array's elements are: ");
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = currentValue.Next(-10, 11);
    Console.Write($"{randomArray[i]} ");
}
Console.WriteLine();
for (int i = 0; i < randomArray.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Even element {i} is {randomArray[i]}");
        continue;
    }
}


//2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.

//int[] randomArray = new int[10];
//Random currentValue = new Random();
//Console.Write("All array's elements are: ");
//for (int i = 0; i < randomArray.Length; i++)
//{
//    randomArray[i] = currentValue.Next(-10, 11);
//    Console.Write($"{randomArray[i]} ");
//}
//Console.WriteLine();
//int result = 0;
//foreach (int arrayElement in randomArray)
//{
//    result += arrayElement;
//}
//Console.WriteLine($"Sum of array's elements is: {result}");
//if (result < 0)
//{
//    Console.WriteLine("Sum of array's elements is negative: true");
//}
//else
//{
//    Console.WriteLine("Sum of array's elements is negative: false");
//}


//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
//(у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ...,
//в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

//int[,] array = new int[9, 9];
//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        array[i, j] = (i + 1) * (j + 1);
//        Console.Write($"{array[i, j]} ");
//    }
//    Console.WriteLine();
//}


//4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран:
//а) максимальний елемент масиву;
//б) мінімальний елемент масиву;
//в) координати мінімального елемента масиву.
//г) координати максимального елемента масиву.

//byte[,] randomArray = new byte[5, 5];
//Random currentValue = new Random();
//byte maxElement = 0;
//byte minElement = 0;
//byte iForMaxElement = 0;
//byte jForMaxElement = 0;
//byte iForMinElement = 0;
//byte jForMinElement = 0;
//Console.WriteLine("All array's elements are: ");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        randomArray[i, j] = (byte)currentValue.Next(0, 256);
//        Console.Write($"{randomArray[i, j]} ");
//        if (i == 0 && j == 0)
//        {
//            maxElement = randomArray[i, j];
//            minElement = randomArray[i, j];
//        }
//        if (randomArray[i, j] > maxElement)
//        {
//            maxElement = randomArray[i, j];
//            iForMaxElement = (byte)i;
//            jForMaxElement = (byte)j;
//        }
//        if (randomArray[i, j] < minElement)
//        {
//            minElement = randomArray[i, j];
//            iForMinElement = (byte)i;
//            jForMinElement = (byte)j;
//        }
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"Max array's element is: {maxElement}");
//Console.WriteLine($"Min array's element is: {minElement}");
//Console.WriteLine($"Index of max array's element is: [{iForMaxElement},{jForMaxElement}]");
//Console.WriteLine($"Index of min array's element is: [{iForMinElement},{jForMinElement}]");




//5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
//а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат.
//Наприклад: 

//Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday

//Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday

//int rightInputNumber = 0;
//int divideResult = 0;
//bool isRightNumber = false;

//while (!isRightNumber)
//{
//    Console.Write("Enter your number (more then 0): ");
//    string? inputNumber = Console.ReadLine();
//    if (int.TryParse(inputNumber, out rightInputNumber) && rightInputNumber > 0)
//    {
//        divideResult = rightInputNumber % 7;
//        Console.Write($"{rightInputNumber} days from now, it will be {(WeekDays)divideResult+1}");
//        isRightNumber = true;        
//    }
//    else
//{
//    Console.WriteLine("You entered invalid number. Try again.");
//}
//}
//    enum WeekDays
//{
//    Monday = 1,
//    Tuesday = 2,
//    Wednesday = 3,
//    Thursday = 4,
//    Friday = 5,
//    Saturday = 6,
//    Sunday = 7
//}

