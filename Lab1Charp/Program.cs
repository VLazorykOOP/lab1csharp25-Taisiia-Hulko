using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nLab 1 - Виберіть завдання:");
            Console.WriteLine("1. Обчислення гіпотенузи трикутника");
            Console.WriteLine("2. Перевірка розв'язків квадратного рівняння");
            Console.WriteLine("3. Перевірка положення точки відносно заштрихованих зон");
            Console.WriteLine("4. Визначення місяця за кількістю днів з 1 січня 1990 року");
            Console.WriteLine("5. Обчислення різниці двох дійсних чисел");
            Console.WriteLine("6. Обчислення значення виразу");
            Console.WriteLine("0. Вийти");
            Console.Write("Вибір: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }

    static void Task1()
    {
        Console.WriteLine("\nОбчислення гіпотенузи трикутника");
        Console.Write("Введіть довжину першого катета: ");
        double a = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введіть довжину другого катета: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Гіпотенуза: {c}");
    }

    static void Task2()
    {
        Console.WriteLine("\nПеревірка розв'язків квадратного рівняння ax^2 + bx + c = 0");
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine() ?? "0"); //якщо введення відсутнє повертає null як 0
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введіть c: ");
        double c = double.Parse(Console.ReadLine() ?? "0");

        double D = b * b - 4 * a * c;

        if (D > 0)
        {
            Console.WriteLine("Рівняння має два дійсні корені.");
        }
        else if (D == 0)
        {
            Console.WriteLine("Рівняння має один дійсний корінь.");
        }
        else
        {
            Console.WriteLine("Рівняння не має дійсних коренів.");
        }
    }

    static void Task3()
    {
        Console.WriteLine("\nПеревірка положення точки відносно заштрихованих зон");
        Console.Write("Введіть координату x: ");
        double x = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введіть координату y: ");
        double y = double.Parse(Console.ReadLine() ?? "0");

        double r = Math.Sqrt(x * x + y * y);
        const double innerShadedRadius = 15;
        const double outerShadedRadius = 25;
        const double epsilon = 1e-6; // Допустима похибка

        if (Math.Abs(r - innerShadedRadius) < epsilon || Math.Abs(r - outerShadedRadius) < epsilon)
        {
            Console.WriteLine("На межі");
        }
        else if (r < innerShadedRadius || r > outerShadedRadius)
        {
            Console.WriteLine("Так (точка всередині заштрихованої області)");
        }
        else
        {
            Console.WriteLine("Ні (точка поза заштрихованою областю)");
        }
    }
    //done
    static void Task4()
    {
        Console.WriteLine("\nВизначення місяця за кількістю днів з 1 січня 1990 року");
        Console.Write("Введіть кількість днів (n > 0): ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n <= 0)
        {
            Console.WriteLine("Число має бути більше 0.");
            return;
        }

        DateTime startDate = new DateTime(1990, 1, 1);
        DateTime resultDate = startDate.AddDays(n - 1); // -1 бо 1 січня вже є першим днем

        Console.WriteLine($"Назва поточного місяця: {resultDate.ToString("MMMM")}"); // MMMM - повна назва місяця
    }

    static void Task5()
    {
        Console.WriteLine("\nОбчислення різниці двох дійсних чисел");
        Console.Write("Введіть перше число: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введіть друге число: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        double difference = CalculateDifference(num1, num2);
        Console.WriteLine($"Різниця: {difference}");
    }

    static double CalculateDifference(double a, double b)
    {
        return a - b;
    }

    static void Task6()
    {
        Console.WriteLine("\nОбчислення значення виразу");
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine() ?? "0");

        double result = (x * y) + ((x + (y * y) + 3) / (x * x + 5));
        Console.WriteLine($"Результат: {result}");
    }
}
