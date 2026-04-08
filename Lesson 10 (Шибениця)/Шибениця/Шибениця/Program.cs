//Написати свій власний варіант гри “Шибениця”. Це гра, де треба вгадати посимвольно зашифроване слово. Нехай слово вже буде відомо програмі. Користувач може вводити по одній літері та має обмежену кількість невірних спроб. Очікувана гра має виглядати приблизно наступним чином:

//Copy code
//Вітаємо! Спробуйте вгадати зашифроване слово! 
//Кількість літер у слові: 6
//Кількість можливих невірних спроб: 6

//Введіть вашу літеру: у
//Такої літери немає! Залишилось спроб: 5
//Введіть вашу літеру: н
//Такої літери немає! Залишилось спроб: 4
//Введіть вашу літеру: а
//Така літера є у слові! Позиція літери: 4,6
//Введіть вашу літеру: о
//Така літера є у слові! Позиція літери: 2
//Введіть вашу літеру: с
//Така літера є у слові! Позиція літери: 1
//Введіть вашу літеру: з
//Такої літери немає! Залишилось спроб: 3
//Введіть вашу літеру: б
//Така літера є у слові! Позиція літери: 3
//Введіть вашу літеру: к

//Вітаємо, ви вгадали слово! Зашифроване слово: собака.
//Дякуємо за гру.

using System.Collections.Generic;

string secretWord = "собака";
char[] secretArray = secretWord.ToCharArray();
char[] currentWord = new char[secretArray.Length];
int tryCounter = secretArray.Length;
List <int> positions = new List<int>();  // Масив, в який записуються позиції вгаданої літери, оновлюється при кожній новій спробі
List <char> usedLetters = new List<char>();  //Масив для збереження використаних літер
Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");  
Console.WriteLine($"Кількість літер у слові: {secretArray.Length}");
Console.WriteLine($"Кількість можливих невірних спроб: {tryCounter}");

for (int i=0;  i < secretArray.Length; i++) // Заповнюю зірочками слово, яке буде виводитися потім гравцю
{
    currentWord[i] = '*';
}

while (tryCounter > 0 && new string(currentWord).Contains('*')) //Перевіряю, що залишилися спроби і слово повністю не розгадане (наявність зірочок)
{
    char guess = char.ToLower(LetterInput());
    if (usedLetters.Contains(guess))                          //Перевірка на повторний ввод літери без зміни кількості спроб
    {
        Console.Write($"Здається, Ви помилилися. ");
    }
    usedLetters.Add(guess);

    bool found = false;
    positions.Clear();

    for (int i = 0; i < secretArray.Length; i++)
    {
        if (secretArray[i] == guess)
        {
            currentWord[i] = guess;     // Вгадана літера записується замість зірочок
            positions.Add(i + 1);
            found = true;
        }       
    }

    if (found)
    {
        Console.Write($"Така літера є у слові! Позиція літери: ");
        positions.ForEach(p => Console.Write(p + " "));
        Console.WriteLine($"\nПоточне слово: {new string(currentWord)}");
    }
    else
    {
        tryCounter--;
        Console.WriteLine($"Такої літери немає! Залишилось спроб: {tryCounter}");
    }
}
if (!new string(currentWord).Contains('*'))
    Console.WriteLine($"Перемога! Ви вгадали слово: {secretWord}");
else
    Console.WriteLine($"Програш! Загадане слово було: {secretWord}");



char LetterInput()               // Метод для вводу поточної літери
{
    Console.Write("Введіть вашу літеру: ");
    bool isRightInput = false;
    char currentLetter = '\0';
    while (!isRightInput)
    {
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsLetter(input[0]))
        {
            currentLetter = input[0];
            isRightInput = true;
            break;
        }
        else
        {
            Console.Write("Ви ввели не літеру. Спробуйте ще раз: ");
        }
    }
    return currentLetter;
}


