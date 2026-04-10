//1.Створіть окремий проект.

//2.Створіть окремий статичний клас.До нього треба додати рекурсивну функцію для обчислення числа Фібоначчі певного порядку.
//Метод приймає номер числа і повертає число Фібоначчі вказаного номеру.
//Вважати першим числом послідовності 0, другим — 1. Детально про числа Фібоначчі тут. Наприклад:

//Вхідний параметр: 3
//Вихідне значення: 1

//Вхідний параметр: 11
//Вихідне значення: 55

int n;
bool isRightEnter = false;

while (!isRightEnter)
{
    Console.Write("Введіть порядковий номер потрібного числа Фібоначчі: ");
    string? inputN = Console.ReadLine();
    if (int.TryParse(inputN, out n))
    {
        try
        {
            int result = MyClass.Fibonacci(n);
            Console.WriteLine($"{n} число Фібоначчі - це {result}");
            isRightEnter = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка у розрахунках!");
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Ви ввели недозволене значення. Спробуйте ще раз");
    }

}


public static class MyClass
{
    public static int Fibonacci(int i)
    {
        if (i < 1)
        {
            throw new Exception("Число має бути більше за 0!");
        }
        if (i == 1)
        {
            return 0;
        }
        if (i == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }

}
