using System;

namespace SortTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив чисел для сортировки
            int[] numbers = { 34, 7, 23, 32, 5, 62, 100, 1, 14 };

            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

            // вызов метода сортировки
            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("Отсортированный массив:");
            PrintArray(numbers);
        }

        // метод сортировки
        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // индекс разделителя
                int pi = Partition(array, low, high);

                // сортировка элементов до и после разделителя
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        // метод для разделения массива
        static int Partition(int[] array, int low, int high)
        {
            // последний элемент в качестве опорного
            int pivot = array[high];
            int i = (low - 1); // наименьший элемент

            for (int j = low; j < high; j++)
            {
                // если элемент меньше или равен опорному
                if (array[j] <= pivot)
                {
                    i++; // увеличиваем индекс меньшего элемента
                    Swap(ref array[i], ref array[j]); // элементы меняются местами
                }
            }
            Swap(ref array[i + 1], ref array[high]); // опорный элемент меняется с элементом после последнего меньшего
            return i + 1; // индекс разделителя
        }

        // метод для обмена значениями двух элементов
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // метод для вывода массива
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
