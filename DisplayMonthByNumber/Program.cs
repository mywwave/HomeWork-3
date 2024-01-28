//Написать программу для вывода названия поры года по номеру месяца.
//При решении используйте оператор switch-case.

Console.WriteLine("Введите номер месяца");
try
{
    int number = int.Parse(Console.ReadLine());
    switch (number)
    {
        case 1:
        case 2:
        case 12:
            Console.WriteLine("Зима");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Весна");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Лето");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Осень");
            break;
        default:
            Console.WriteLine("Такого месяца нет");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат введенного значения");
}