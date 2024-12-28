using System;

namespace CalculatorTask
{
    public class Calculator
    {
        // свойство
        private double result;
        // геттер
        public double Result => result;

        // сложение
        public Calculator Sum(double value)
        {
            result += value;
            return this;
        }

        // вычитание
        public Calculator Minus(double value)
        {
            result -= value;
            return this;
        }

        // умножение
        public Calculator Multiply(double value)
        {
            result *= value;
            return this;
        }

        // деление
        public Calculator Divide(double value)
        {
            if (value == 0) // проверка на деление на ноль
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            result /= value;
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calc = new Calculator();
                double finalResult = calc.Sum(50).Sum(30).Minus(20).Divide(2).Result;
                Console.WriteLine($"Результат: {finalResult}"); // 30
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}