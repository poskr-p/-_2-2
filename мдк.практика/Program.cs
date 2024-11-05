using System.Linq.Expressions;

namespace мдк.практика
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Введите действие");
                Console.WriteLine("сложение + \nвычитание - \nумножение * \nделение / \nкорень \nвозведение в степень ^ ");
                Console.WriteLine();
                string ssign = Console.ReadLine();
                double resultSqrt;
                if (ssign == "корень")
                {
                    Console.WriteLine("Введите число:");
                    double numForSqrt = Convert.ToDouble(Console.ReadLine());
                    resultSqrt = Math.Sqrt(numForSqrt);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Результат вычислений: {resultSqrt}");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine("Введите первое число");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result;

                switch (ssign)
                {
                    case "+":
                        result = num1 + num2;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Результат вычислений: {result}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Результат вычислений: {result}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Результат вычислений: {result}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Результат вычислений: {result}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case "^":
                        result = Math.Pow(num1, num2);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Результат вычислений: {result}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    
                    default:
                        Console.WriteLine("Неверно введено действие");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}

