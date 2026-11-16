using System;
using ClassLibrary1; // Подключаем нашу библиотеку

namespace Тестовая
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса из библиотеки
            MathOperations math = new MathOperations();

            

            // 1. Тестируем void-методы
            math.ShowHello();

            Console.Write("Введите число для возведения в квадрат: ");
            int numSquare = Convert.ToInt32(Console.ReadLine()); // Считываем число с клавиатуры
            math.ShowSquare(numSquare); // Передаем это число в метод библиотеки

            

            // 2. Тестируем метод Add (сложение)
            Console.Write("Введите первое число для сложения: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число для сложения: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = math.Add(a, b);
            Console.WriteLine($"Результат сложения: {sum}");

            // 3. Тестируем метод Divide (деление)
            Console.Write("\nВведите делимое (дробное число): ");
            double divA = Convert.ToDouble(Console.ReadLine()); // Считываем дробное число

            Console.Write("Введите делитель (дробное число): ");
            double divB = Convert.ToDouble(Console.ReadLine());

            double divResult = math.Divide(divA, divB);
            Console.WriteLine($"Результат деления: {divResult}");

            // 4. Тестируем метод GetGreeting (строка)
            Console.Write("\nВведите ваше имя: ");
            string name = Console.ReadLine(); // Считываем строку

            string greeting = math.GetGreeting(name);
            Console.WriteLine($"Ответ библиотеки: {greeting}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
