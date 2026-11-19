using System;

namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ПРИМЕР 1 (с 3-го фото):
            Console.WriteLine("Тест 1: Деление");
            try
            {
                int a = 10;
                int b = a / 0; // Деление на ноль
                Console.WriteLine($"Результат: {b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
           



            // ПРИМЕР 2 (с 1-го фото): Ошибка массива
            Console.WriteLine("Тест 2: Массив");
            try
            {
                int[] numbers = new int[3]; // Создаем массив из 3 элементов
                numbers[5] = 8; // Обращаемся к 5-му индексу (выход за пределы)

                int x = 2;
                int y = x / 0; // Эта строка не выполнится
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

           




            // ПРИМЕР 3 (с 2-го фото):
            Console.WriteLine("Тест 3: Фильтры");
            int a1 = 2;
            int b2 = 0;

            try
            {
                int result1 = a1 / b2;
                int result2 = b2 / a1;
            }
            catch (DivideByZeroException) when (b2 == 0)
            {
                Console.WriteLine("Делитель не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}