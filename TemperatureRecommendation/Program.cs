//Для введенного числа t (температура на улице) вывести: V
//Если t > –5, то вывести «Тепло». V
//Если –5 >= t > –20, то вывести «Нормально». V
//Если –20 >= t, то вывести «Холодно». V

Console.WriteLine("Введите температуру на улице");
try
{
    int temperature = int.Parse(Console.ReadLine());
    if (temperature > -5)
    {
        Console.WriteLine("Тепло");
    }
    else if (temperature > -20)
    {
        Console.WriteLine("Нормально");
    }
    else
    {
        Console.WriteLine("Холодно");
    }
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат введенного значения");
}