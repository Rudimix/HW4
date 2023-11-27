using System;

namespace HW4
{
    class Program
    {
        static void Main()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите количество строк в массиве:");
                n = int.Parse(Console.ReadLine());
                if (n > 0) break;
                else Console.WriteLine("Столько строк быть не может");
            }
            double sum, minValue, maxValue;
            double[,] array = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите значения для строки {i + 1}:");
                string input = Console.ReadLine();
                string[] values = input.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    if (!double.TryParse(values[j], out array[i, j]))
                    {
                        array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                GetMinValue(array, i, out minValue);
                GetMaxValue(array, i, out maxValue);
                GetSum(array, i, out sum);

                Console.WriteLine($"Минимальное значение в строке {i + 1}: {minValue}");
                Console.WriteLine($"Максимальное значение в строке {i + 1}: {maxValue}");
                Console.WriteLine($"Сумма значений в строке {i + 1}: {sum}");
            }
        }

        static void GetMinValue(double[,] array, int row, out double min)
        {
            min = array[row, 0];
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] < min)
                {
                    min = array[row, i];
                }
            }
        }

        static void GetMaxValue(double[,] array, int row, out double max)
        {
            max = array[row, 0];
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] > max)
                {
                    max = array[row, i];
                }
            }
        }

        static void GetSum(double[,] array, int row, out double result)
        {
            result = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                result += array[row, i];
            }
        }
    }
}