using System;

namespace ТЕМА2
{
    // Создаем класс для калькулятора (Задание 1)
    public class Calculator
    {
        // 1 метод Add для сложения двух чисел,публичный вне класса вызвыали
        public int Add(int a, int b)
        {
            return a + b;
        }

        // 2 метод Dev для нахождения частного двух числел, приватный , работает только внутри класса 
        private double Dev(int a, int b)
        {
            return (double)a / b;
        }

        // Публичный метод для вызова приватного Dev, так  как он приватный и вызываем с другого класса
        public void ShowDivision(int a, int b)
        {
            double result = Dev(a, b);
            Console.WriteLine($"Результат деления {a} на {b} = {result}");
        }
    }

    // Создаем класс для пльзователя (Задание 2) get; set;- возможность получать и записывать вводимые данные 
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
    //Создаем итоговый класс, где показываем как это все работает 
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("ЗАДАНИЕ 1:");

            // Ввод первого числа
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ввод второго числа
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Вызов методов
            int sum = calc.Add(num1, num2);
            Console.WriteLine($"Сумма: {sum}");
            calc.ShowDivision(num1, num2);

            Console.WriteLine("\nЗАДАНИЕ 2:");

            // Создаем пустой объект пользователя
            User myUser = new User();

            // Запрашиваем данные с клавиатуры
            Console.Write("Введите имя: ");
            myUser.Name = Console.ReadLine();

            Console.Write("Введите email: ");
            myUser.Email = Console.ReadLine();

            Console.Write("Введите возраст: ");
            myUser.Age = Convert.ToInt32(Console.ReadLine());

            // Выводим результат
            Console.WriteLine("\nДанные пользователя");
            Console.WriteLine($"Имя: {myUser.Name}");
            Console.WriteLine($"Email: {myUser.Email}");
            Console.WriteLine($"Возраст: {myUser.Age}");

           
            Console.ReadKey();
        }
    }
}
