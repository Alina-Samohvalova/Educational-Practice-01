using System;

namespace ТЕМА5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем две строки для сравнения
            string str1 = "Оценка";
            string str2 = "оценка"; // Обрати внимание: первая буква маленькая!
            string str3 = "Оценка";

            Console.WriteLine($"Строка 1: {str1}");
            Console.WriteLine($"Строка 2: {str2}");
            Console.WriteLine($"Строка 3: {str3}\n");





            // 1. Операторы == и != (Сравнивают строки с учетом регистра)
            Console.WriteLine("1. Операторы == и !=");
            Console.WriteLine($"str1 == str3: {str1 == str3}"); // True (полностью одинаковые)
            Console.WriteLine($"str1 == str2: {str1 == str2}"); // False (разный регистр)
            Console.WriteLine($"str1 != str2: {str1 != str2}"); // True (полностью разные)
            Console.WriteLine();







            // 2. Метод Equals() (Проверяет на полное совпадение)
            Console.WriteLine("2. Метод Equals()");
            Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); // False
            Console.WriteLine($"str1.Equals(str3): {str1.Equals(str3)}"); // True
            // Equals можно использовать с игнорированием регистра:
            Console.WriteLine($"str1.Equals(str2, StringComparison.OrdinalIgnoreCase): {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}"); // True
            Console.WriteLine();






            // 3. Метод Compare() (Лексикографическое сравнение, чувствителен к регистру)
            Console.WriteLine("3. Метод Compare()");
            Console.WriteLine($"String.Compare(str1, str2): {String.Compare(str1, str2)}"); // >0 (Заглавная 'О' идет раньше строчной 'о')
            Console.WriteLine($"String.Compare(str1, str3): {String.Compare(str1, str3)}"); // 0
            Console.WriteLine();







            // 4. Метод CompareOrdinal() (Сравнивает коды символов)
            Console.WriteLine("4. Метод CompareOrdinal()");
            Console.WriteLine($"String.CompareOrdinal(str1, str2): {String.CompareOrdinal(str1, str2)}"); // Разница в кодах символов
            Console.WriteLine($"String.CompareOrdinal(str1, str3): {String.CompareOrdinal(str1, str3)}"); // 0
            Console.WriteLine();






            // 5. Метод Contains() (Проверяет, содержится ли подстрока)
            Console.WriteLine("5. Метод Contains()");
            Console.WriteLine($"str1.Contains(\"цен\"): {str1.Contains("цен")}"); // True (есть в слове "Оценка")
            Console.WriteLine($"str2.Contains(\"мир\"): {str2.Contains("мир")}"); // False (нет такого)
            Console.WriteLine();





            // 6. Метод IndexOf() (Ищет индекс первого вхождения подстроки)
            Console.WriteLine("--- 6. Метод IndexOf() ---");
            Console.WriteLine($"str1.IndexOf(\"е\"): {str1.IndexOf("е")}"); // 2 (индекс буквы 'е' в слове "Оценка")
            Console.WriteLine($"str1.IndexOf(\"ка\"): {str1.IndexOf("ка")}"); // 4 (индекс начала подстроки "ка")
            Console.WriteLine($"str1.IndexOf(\"мир\"): {str1.IndexOf("мир")}"); // -1 (если не найдено, возвращает -1)

           
        }
    }
}