using System;

namespace TЕМА7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Массивы");
            int[] m1 = { 5, 2, 8, 1, 9 };
            int[] m2 = { 4, 7, 3 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", m1));

            // Вызываем методы
            SortAscending(m1);
            Console.WriteLine("По возрастанию: " + string.Join(", ", m1));

            SortDescending(m1);
            Console.WriteLine("По убыванию: " + string.Join(", ", m1));

            int[] mnew = MergeArrays(m1, m2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", mnew));






            Console.WriteLine("\nЗАДАНИЕ 2: Разность с числом 123");
            Console.Write("Введите любое целое число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = GetAbsoluteDifference(n);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }

        //Сортировка по возрастанию
        static void SortAscending(int[] arr)
        {
            Array.Sort(arr);
        }

        //Сортировка по убыванию
        static void SortDescending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        //Объединение двух массивов
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);
            return result;
        }

        //Действие для второго упр
        static int GetAbsoluteDifference(int n)
        {
            int diff = Math.Abs(n - 123); // Абсолютная разность

            // Если n больше 123, возвращаем тройную разность
            if (n > 123)
            {
                return diff * 3;
            }
            return diff;
        }
    }
}