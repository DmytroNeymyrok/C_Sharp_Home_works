// Назва дня тижня

Console.WriteLine("Hello! Type a number of the week's day (from 1 to 7): ");
string inputNumber = Console.ReadLine();
if (sbyte.TryParse(inputNumber, out sbyte dayNumber)) {
    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Your day is Sunday");
            break;
        case 2:
            Console.WriteLine("Your day is Monday");
            break;
        case 3:
            Console.WriteLine("Your day is Tuesday");
            break;
        case 4:
            Console.WriteLine("Your day is Wednesday");
            break;
        case 5:
            Console.WriteLine("Your day is Thursday");
            break;
        case 6:
            Console.WriteLine("Your day is Friday");
            break;
        case 7:
            Console.WriteLine("Your day is Saturday");
            break;
        default:
            Console.WriteLine("You typed wrong number");
            break;
    }
} else
{
    Console.WriteLine("You didn't type a number");
}
