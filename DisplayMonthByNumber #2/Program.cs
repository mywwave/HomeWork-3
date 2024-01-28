//Написать программу для вывода названия поры года по номеру месяца.
//При решении используйте оператор if-else-if.

Console.WriteLine("Введите номер месяца");
try
{
    int number = int.Parse(Console.ReadLine());
    if (number == 1 || number == 2 || number == 12)
    {
        Console.WriteLine("Зима");
    }
    else if (number >= 3 && number <= 5)
    {
        Console.WriteLine("Весна");
    }
    else if (number >= 6 && number <= 8)
    {
        Console.WriteLine("Лето");
    }
    else if (number >= 9 && number <= 11)
    {
        Console.WriteLine("Осень");
    }
    else
    {
        Console.WriteLine("Такого месяца нет");
    }
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат введенного значения");
}