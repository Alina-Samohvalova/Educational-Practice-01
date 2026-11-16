using System;

namespace ClassLibrary1
{
    public class MathOperations
    {
        //2 метода с типом void!

        //1 Просто выводит приветствие
        public void ShowHello()
        {
            Console.WriteLine("Это сообщение из библиотеки.");
        }

        //2 Выводит квадрат числа
        public void ShowSquare(int num)
        {
            Console.WriteLine($"Квадрат числа {num} равен {num * num}");
        }

        //3 метода с возвращаемыми значениями (разных типов)

        //Возвращает int (целое число)
        public int Add(int a, int b)
        {
            return a + b;
        }

        //Возвращает double (дробное число)
        public double Divide(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }

        //Возвращает string (строку)
        public string GetGreeting(string name)
        {
            return $"{name}!Вы посмотрели выполнение работы(ТЕМА3) ";
        }
    }
}
