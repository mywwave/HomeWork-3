while (true)
{
    decimal num1, num2;
    Console.WriteLine("Введите первое число");
    while (!decimal.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Пожалуйста, введите корректное число.");
    }

    Console.WriteLine("Введите второе число");
    while (!decimal.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Пожалуйста, введите корректное число.");
    }

    Console.WriteLine("Выберите операцию: +, -, *, /, %, sqrt");
    string operation = Console.ReadLine();

    decimal result = 0;
    switch (operation)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
            break;
        case "%":
            result = num1 * (num2 / 100);
            break;
        case "sqrt":
            result = (decimal)Math.Sqrt((double)num1);
            break;
        default:
            Console.WriteLine("Неверная операция");
            continue;
    }

    Console.WriteLine("Результат: " + result);

    Console.WriteLine("Хотите продолжить? (y/n)");

    string continueInput = Console.ReadLine().ToLower();
    if (continueInput == "y")
    {
        Console.Clear();
    }
    else
    {
        break;
    }
}