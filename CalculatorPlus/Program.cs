PrintInfo();
while (true)
{
    try
    {

        List<string> inputs = new List<string>();
        string? inputNumber = "";
        string? inputOperation = "";

        while (inputOperation != "=")
        {
            Console.Write("Введите число: ");
            inputNumber = Console.ReadLine();
            if (!double.TryParse(inputNumber, out double number))
            {
                throw new ArgumentException("Неверный ввод числа");
            }
            inputs.Add(inputNumber);

            Console.Write("Введите операцию: ");
            inputOperation = Console.ReadLine();
            inputs.Add(inputOperation);
        }

        double result = double.Parse(inputs[0]);
        for (int i = 1; i < inputs.Count - 1; i += 2)
        {
            double number;
            if (!double.TryParse(inputs[i + 1], out number))
            {
                throw new ArgumentException("Неверный ввод числа");
            }
            string operation = inputs[i];
            switch (operation)
            {
                case "+":
                    result += number;
                    break;
                case "-":
                    result -= number;
                    break;
                case "*":
                    result *= number;
                    break;
                case "/":
                    if (number == 0)
                    {
                        throw new DivideByZeroException("Нельзя делить на ноль");
                    }
                    result /= number;
                    break;
                case "%":
                    result %= number;
                    break;
                case "^":
                    if (number <= 0)
                    {
                        throw new ArgumentException("Неверный ввод для возведения в степень");
                    }
                    result = Math.Pow(result, 1 / number);
                    break;
                default:
                    throw new ArgumentException("Неверная операция");
            }
        }
        Console.WriteLine($"Результат всех введённых операций: {string.Join(" ", inputs)} {result}");

        Console.WriteLine("Хотите продолжить? (y/n)");

        string continueInput = Console.ReadLine().ToLower();
        if (continueInput == "y")
        {
            Console.Clear();
            PrintInfo();
        }
        else
        {
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошла ошибка: {ex.Message}");
    }
}

static void PrintInfo()
    {
        Console.WriteLine("Добро пожаловать в калькулятор");
        Console.WriteLine();
        Console.WriteLine("Список поддерживаемых арифметический операций");
        Console.WriteLine();
        Console.WriteLine("+ : сложение чисел");
        Console.WriteLine("- : вычитание чисел");
        Console.WriteLine("* : умножение чисел");
        Console.WriteLine("/ : деление чисел");
        Console.WriteLine("% : от числа");
        Console.WriteLine("^ : квадратный корень");
        Console.WriteLine();
        Console.WriteLine("Введите '=' для получения результата");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Дробные числа вводить строго через ','");
    }
 