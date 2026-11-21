using System;
using System.Globalization; // для ParseExact

namespace TЕМА6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6: Работа с датами\n");

            // 1. Parse() - превращает строку в дату (если формат стандартный)
            Console.WriteLine("Метод Parse()");
            string dateStr1 = "03.07.2008";
            DateTime date1 = DateTime.Parse(dateStr1);
            Console.WriteLine($"Строка '{dateStr1}' стала датой: {date1.ToShortDateString()}\n");





            // 2. ParseExact() - превращает строку в дату, если мы УКАЗАЛИ точный формат
            Console.WriteLine("Метод ParseExact()");
            string dateStr2 = "2026.11.21";
            // Указываем формат: ГГГГ-ММ-ДД
            DateTime date2 = DateTime.ParseExact(dateStr2, "yyyy.MM.dd", CultureInfo.InvariantCulture);
            Console.WriteLine($"Строка '{dateStr2}' стала датой: {date2.ToShortDateString()}\n");






            // 3. TryParse() - не вызовет ошибку, если текст неверный
            Console.WriteLine("Метод TryParse()");
            string badDateStr = "Тут не дата)";
            bool isSuccess = DateTime.TryParse(badDateStr, out DateTime date3);
            Console.WriteLine($"Попытка превратить '{badDateStr}' в дату. Успех? -> {isSuccess}\n");





            // 4. TryParseExact() - безопасная попытка с точным форматом
            Console.WriteLine("Метод TryParseExact()");
            string goodDateStr = "21.11.2026";
            // Указываем точный формат!: дд-мм-гггг
            bool isSuccessExact = DateTime.TryParseExact(goodDateStr, "dd.MM.yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4);
            Console.WriteLine($"Попытка превратить '{goodDateStr}' в дату. Успех? -> {isSuccessExact}");
            if (isSuccessExact) Console.WriteLine($"Результат: {date4.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}