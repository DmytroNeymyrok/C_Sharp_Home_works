//Створіть консольний додаток на мові C#, який реалізує функціональність списку справ. Ваш список справ повинен мати наступні можливості:

//Додавання справи: Напишіть функцію, яка додає нову справу до списку. Користувач повинен мати можливість ввести назву справи.
//Виведення всіх справ: Реалізуйте функцію, яка виводить на екран усі справи зі списку.
//Відмітка про виконання: Додайте можливість позначити справу як виконану. Користувач повинен ввести номер справи, яку він хоче відмітити.
//Видалення справи: Напишіть функцію, яка дозволяє видалити справу зі списку. Користувач повинен ввести номер справи для видалення.

//Завантаження списку справ: Додайте можливість показати список справ збережений у List<string> (якщо він не пустий) і виведіть його на екран.

//Не забудьте обробляти помилки, такі як некоректний ввід користувача чи відсутність списку справ.

using System;
using System.Collections.Generic;


class MyProgram
{
    static List<ToDoItem> taskList = new List<ToDoItem>(); // Список, в який будуть зберігатися справи
    static void Main (string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n--- МЕНЮ СПИСКУ СПРАВ ---");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Показати всі справи");
            Console.WriteLine("3. Відмітити як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Вихід");
            Console.Write("Виберіть дію: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Програма завершена");
                    isRunning = false; 
                    break;
                default:           // Обробка помилок (якщо введено щось інше)
                    Console.WriteLine("Помилка: Невірний вибір. Спробуйте ще раз (1-5)");
                    break;
            }
        }
    }

    static void AddTask() // Метод для додавання справи
    {
        Console.Write("Введіть назву справи: ");
        string title = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Справа не може бути порожньою");
        }
        else
        {
            ToDoItem newTask = new ToDoItem(title);
            taskList.Add(newTask);
            Console.WriteLine("Справу успішно додано!");
        }
    }


    static void ShowTasks()  //   Метод для виведення поточного списку справ
    {
        Console.WriteLine("\n--- ВАШ СПИСОК СПРАВ ---");
        if (taskList.Count == 0)
        {
            Console.WriteLine("Список не містить справ");
        }
        else
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                string status;
                if (taskList[i].IsCompleted)
                {
                    status = "[X]";
                }
                else
                {
                    status = "[ ]";
                }
                Console.WriteLine($"{i + 1}. {status} {taskList[i].Title}");
            }
        }
        Console.WriteLine("------------------------");
    }


    static void CompleteTask() //  Метод для відмічання виконаних справ
    {
        ShowTasks();
        if (taskList.Count == 0)
        {
            Console.WriteLine("Список не містить справ");
            return;
        }
        else
        {
            Console.Write("Введіть номер справи, яку виконано: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= taskList.Count)
                {
                    taskList[taskNumber - 1].IsCompleted = true;
                    Console.WriteLine($"Справа {taskNumber} позначена як виконана!");
                }
                else
                {
                    Console.WriteLine("Помилка: Справи з таким номером не існує.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: Введіть коректне число.");
            }
        }
    }


    static void DeleteTask() //  Метод для відмічання виконаних справ
    {
        ShowTasks();
        if (taskList.Count == 0)
        {
            Console.WriteLine("Список не містить справ");
            return;
        }
        else
        {
            Console.Write("Введіть номер справи, яку треба видалити: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= taskList.Count)
                {
                    taskList.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Справу успішно видалено!");
                }
                else
                {
                    Console.WriteLine("Помилка: Справи з таким номером не існує.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: Введіть коректне число.");
            }
        }
    }

}



class ToDoItem
{
    public string Title { get; set; } // Назва справи
    public bool IsCompleted { get; set; } // Статус справи
    public ToDoItem(string title) //Конструктор для створення нової справи
    {
        Title = title;
        IsCompleted = false;
    }
}


