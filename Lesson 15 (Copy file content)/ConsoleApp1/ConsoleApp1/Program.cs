//Ваша мета -створити програму, яка копіює вміст одного текстового файлу в інший. Користувач повинен ввести шлях до вихідного файлу та шлях до файлу,
//в який потрібно скопіювати дані. Після виконання копіювання виведіть повідомлення про успішне завершення.

//Приклад використання:

//Copy code
//Введіть шлях до вихідного файлу: C:\input.txt
//Введіть шлях до файлу, в який потрібно скопіювати дані: C:\output.txt
//Файл успішно скопійовано!


using System.IO;

class MyProgram
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write(@"Введіть шлях до файлу, з якого треба скопіювати дані (в форматі C:\MyFolder\Example.txt): ");
        string? fileFrom = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileFrom))
        {
            Console.WriteLine("Шлях не введено");
            return;
        }

        if (File.Exists(fileFrom))
        {
            Console.Write(@"Введіть шлях до файлу, в який треба скопіювати дані (в форматі C:\MyFolder\Example.txt): ");
            string? fileTo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileTo))
            {
                Console.WriteLine("Шлях не введено");
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(fileFrom);
                File.WriteAllLines(fileTo, lines);
                Console.WriteLine("Дані успішно скопійовано");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Файл для копіювання не знайдено");
            return;
        }
    }
}