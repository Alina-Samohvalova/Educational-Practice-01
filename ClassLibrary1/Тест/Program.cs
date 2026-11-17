using System;
using ClassLibrary1; // Подключаем нашу библиотеку

namespace Тест
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект из библиотеки
            MathOperations math = new MathOperations();

            Console.WriteLine("--- Тестирование DLL ---");

            // Тестируем 2 метода void
            math.ShowHello();
            math.ShowSquare(5);

            // Тестируем 3 метода с разными типами
            int sum = math.Add(10, 20);
            Console.WriteLine($"Сумма (int): {sum}");

            double div = math.Divide(15, 4);
            Console.WriteLine($"Деление (double): {div}");

            string greet = math.GetGreeting("Алина");
            Console.WriteLine($"Строка (string): {greet}");

            Console.ReadKey(); // Чтобы окно не закрылось сразу
        }
    }
}