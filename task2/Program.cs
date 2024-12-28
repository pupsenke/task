using System;

namespace LetterCountTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод строки
            Console.WriteLine("Введите строку для подсчета букв:");
            string input = Console.ReadLine();

            try
            {
                int letterCount = CountLetters(input);
                // вывод результата
                Console.WriteLine($"Количество букв в строке: {letterCount}");
            }
            catch (Exception ex)
            {
                // обработка исключений
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        // метод для подсчета количества букв в строке
        static int CountLetters(string input)
        {
            // проверка что строка не пустая
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Входная строка не может быть пустой");
            }

            int count = 0; // переменная для хранения количества букв

            foreach (char c in input)
            {
                // является ли символ буквой
                if (char.IsLetter(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
