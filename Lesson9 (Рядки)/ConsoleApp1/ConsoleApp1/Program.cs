//ДЗ 9.1.Опис: Ви отримали рядок, який містить ім’я та прізвище користувача. Ваша мета - перевірити, 
//чи починається прізвище на ту ж літеру, що й ім’я. Якщо так, вивести повідомлення
//“Прізвище починається на ту ж літеру, що і ім’я”, інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.

Console.Write("Enter user's name and surname: ");
string? name = Console.ReadLine()?.Trim();
var nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string firstPart = nameParts[0];
string secondPart = nameParts[1];
if (char.ToLower(firstPart[0]) == char.ToLower(secondPart[0]))
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}


//ДЗ 9.2. Ви розробляєте програму для генерації текстового звіту. Ваше завдання - створити текстовий звіт,
//який містить заголовок, дату та список подій. Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати 
//об’єднання рядків. Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .

//using System.Text;
//StringBuilder events = new StringBuilder();
//bool enterEnd = false;
//events.AppendLine("EVENTS LIST: ");
//while (!enterEnd)
//{
//    Console.WriteLine("Enter event's date (or type 'end' to stop): ");
//    string? eventDate = Console.ReadLine();
//    if (eventDate?.ToLower() == "end")
//    {
//        Finish();
//        continue;
//    }
//    Console.WriteLine("Enter event's Name: (or type 'end' to stop)");
//    string? eventName = Console.ReadLine();
//    if (eventName?.ToLower() == "end")
//    {
//        Finish();
//        continue;
//    }
//    events.Append(eventDate).Append('-').AppendLine(eventName);
//}

//Console.WriteLine(events.ToString());

//void Finish()
//{
//    enterEnd = true;
//    Console.Clear();
//}

//ДЗ 9.3. Опис: Ви отримали рядок, який містить декілька слів, розділених комами. Ваша мета - видалити всі пробіли з цього рядка та вивести результат.

//string fullPhrase = "Word1, word2, word3, word4, word5";
//Console.WriteLine($"Phrase before is: {fullPhrase}");
//fullPhrase = fullPhrase.Replace(" ",string.Empty);
//Console.WriteLine($"Phrase after is: {fullPhrase}");


