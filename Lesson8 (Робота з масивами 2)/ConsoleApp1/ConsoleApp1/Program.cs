//1. Написати програму, що знаходить другий найбільший елемент масиву.
bool isWriteNumber = false;
int n = 0;
while (!isWriteNumber)
{
    Console.Write("Enter number of array's elements: ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out n) && n >= 1)
    {
        isWriteNumber = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Try again.");
    }
}
int[] randomArray = new int[n];
Random currentValue = new Random();
Console.WriteLine("All array's elements are:");
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = currentValue.Next(-100, 101);
    Console.Write($"{randomArray[i]} ");
}
int maxElement = int.MinValue;
int secondMaxElement = int.MinValue;
foreach (int value in randomArray)
{
    if (value > maxElement)
    {
        secondMaxElement = maxElement;
        maxElement = value;
    }
    else
    {
        if (value > secondMaxElement && secondMaxElement != maxElement)
        {
            secondMaxElement = value;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Max array's element is: {maxElement}");
Console.WriteLine($"Second max array's element is: {secondMaxElement}");

//2.Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

//bool isRightRowsNumber = false;
//bool isRightColumnsNumber = false;
//int rowsNumber = 0;
//int columnsNumber = 0;
//while (!isRightRowsNumber)
//{
//    Console.Write("Enter number of array's rows: ");
//    string? input = Console.ReadLine();
//    if (int.TryParse(input, out rowsNumber) && rowsNumber >= 1)
//    {
//        isRightRowsNumber = true;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Try again.");
//    }
//}

//while (!isRightColumnsNumber)
//{
//    Console.Write("Enter number of array's columns: ");
//    string? input = Console.ReadLine();
//    if (int.TryParse(input, out columnsNumber) && columnsNumber >= 1)
//    {
//        isRightColumnsNumber = true;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Try again.");
//    }
//}
//Console.Clear();
//int[,] randomArray = new int[rowsNumber, columnsNumber];
//Random currentValue = new Random();
//Console.WriteLine("All array's elements are:");
//for (int i = 0; i < rowsNumber; i++)
//{
//    for (int j = 0; j < columnsNumber; j++)
//    {
//        randomArray[i, j] = currentValue.Next(0, 101);
//        Console.Write($"{randomArray[i, j]} ");
//    }
//    Console.WriteLine();
//}

//int[] longArray = new int[rowsNumber * columnsNumber];
//int index = 0;
//for (int i = 0; i < rowsNumber; i++)
//{
//    for (int j = 0; j < columnsNumber; j++)
//    {
//        longArray[index] = randomArray[i, j];
//        index++;      
//    }
//}
//Array.Sort(longArray);
//Console.WriteLine();

//Console.WriteLine("Sorted array is:");
//index = 0;
//for (int i = 0;i < rowsNumber; i++)
//{
//    for (int j = 0;j < columnsNumber; j++)
//    {
//        randomArray[i, j] = longArray[index];
//        Console.Write($"{randomArray[i, j]} ");
//        index++;
//    }
//    Console.WriteLine();
//}



//3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
//using System.Dynamic;

//bool isWriteNumber = false;
//int n = 0;
//while (!isWriteNumber)
//{
//    Console.Write("Enter number of array's elements: ");
//    string? input = Console.ReadLine();
//    if (int.TryParse(input, out n) && n >= 1)
//    {
//        isWriteNumber = true;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Try again.");
//    }
//}
//int[] randomArray = new int[n];
//Random currentValue = new Random();
//Console.WriteLine("All array's elements are:");
//for (int i = 0; i < randomArray.Length; i++)
//{
//    randomArray[i] = currentValue.Next(-100, 101);
//    Console.Write($"{randomArray[i]} ");
//}
//Console.WriteLine();
//bool isRightIndex = false;
//int delIndex = randomArray[0];
//while (!isRightIndex)
//{
//    Console.Write("Enter index for deleting: ");
//    string? input = Console.ReadLine();
//    if (int.TryParse (input, out delIndex) && delIndex>=0 && delIndex<=(randomArray.Length-1) )
//    {
//        isRightIndex = true;
//    }
//    else
//    {
//        Console.WriteLine("Invalid index. Try again.");
//    }
//}
//Console.WriteLine("Array's elements after deleting are:");
//int[] shortArray = new int[n - 1];
//int j=0;
//for (int i = 0;i < randomArray.Length; i++)
//{
//    if (i!= delIndex)
//    {
//        shortArray[j] = randomArray[i];
//        Console.Write($"{shortArray[j]} ");
//        j++;
//    }
//}


//4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

//bool rightEnter = false;
//int arraySize = 0;
//while (!rightEnter)
//{
//    Console.Write("Enter array's size: ");
//    string? input = Console.ReadLine();
//    if (int.TryParse(input, out arraySize) && arraySize > 0)
//    {
//        rightEnter = true;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Try again.");
//    }
//}
//int[,] randomArray = new int[arraySize, arraySize];
//Random currentValue = new Random();
//int diagonalValue = 0;
//Console.WriteLine("All array's elements are:");
//for (int i = 0; i < arraySize; i++)
//{
//    for (int j = 0; j < arraySize; j++)
//    {
//        randomArray[i, j] = currentValue.Next(-100, 101);
//        Console.Write($"{randomArray[i, j]} ");
//        if (i == j)
//        {
//            diagonalValue += randomArray[i, j];
//        }
//    }
//    Console.WriteLine();
//}
//Console.Write($"Sum of diagonal's elements is: {diagonalValue}");
