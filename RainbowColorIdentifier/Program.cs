//По введенному номеру определить цвет радуги (1 – красный, 4 – зеленый и т.д.).

Console.WriteLine("Введите номер цвета радуги");
try
{
    int colorNumber = int.Parse(Console.ReadLine());
    switch (colorNumber)
    {
        case 1:
            Console.WriteLine("Красный");
            break;
        case 2:
            Console.WriteLine("Оранжевый");
            break;
        case 3:
            Console.WriteLine("Желтый");
            break;
        case 4:
            Console.WriteLine("Зеленый");
            break;
        case 5:
            Console.WriteLine("Голубой");
            break;
        case 6:
            Console.WriteLine("Синий");
            break;
        case 7:
            Console.WriteLine("Фиолетовый");
            break;
        default:
            Console.WriteLine("Нет такого цвета на радуге");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат введенного значения");
}