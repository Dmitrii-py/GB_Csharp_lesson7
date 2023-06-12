using System;
using System.IO;

namespace Project
{
    class Program
    {
        static void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }
        static void FillArray(double[] array, int minValue = -9, int maxValue = 9, int accuracy = 0)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, accuracy);
            }
        }
        static void Fill2DArray(double[,] array, int minValue = -9, int maxValue = 9, int accuracy = 2)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round((random.NextDouble()) * (maxValue - minValue) + minValue, accuracy);
                }
            }
        }
        static void Fill2DArray(int[,] array, int minValue = 0, int maxValue = 9, int accuracy = 0)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
        }
        static void Print2DArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static void PrintArray(double[] array)
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            void Task47()
            //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
            //m = 3, n = 4.
            //0,5 7 -2 -0,2
            //1 -3,3 8 -9,9
            //8 7,8 -7,1 9
            {
                int rows = Input("Введите количество строк: ");
                int colums = Input("Введите количество столбцов: ");
                double[,] numbers = new double[rows, colums];
                int accuracy = 1;
                Fill2DArray(numbers, accuracy);
                Print2DArray(numbers);

            }

            void Task50()
            {
                //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
                //и возвращает значение этого элемента или же указание, что такого элемента нет.
                //Например, задан массив:
                //1 4 7 2
                //5 9 2 3
                //8 4 2 4
                //1, 3 -> 3
                int rows = Input("Введите индекс строки: ");
                int colums = Input("Введите индекс столбца: ");
                int[,] numbers = new int[5, 10];
                Fill2DArray(numbers);
                Print2DArray(numbers);
                if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine($"значение элемента: {numbers[rows, colums]}");
                else Console.WriteLine($"по индексу [{rows} : {colums}] -> элемента в массиве нет");
            }
            void Task52()
            {
                //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                //Например, задан массив:
                //1 4 7 2
                //5 9 5 3
                //8 4 6 4
                //Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
                int rows = Input("Введите количество строк: ");
                int colums = Input("Введите количество столбцов: ");
                int[,] numbers = new int[rows, colums];
                Fill2DArray(numbers);
                Print2DArray(numbers);
                double[] averagecolums = new double[numbers.GetLength(1)];
                for (int i = 0; i < numbers.GetLength(1); i++)
                {
                    double count = 0.0;
                    for (int j = 0; j < numbers.GetLength(0); j++)
                    {
                        count += numbers[j, i];
                    }
                    averagecolums[i] = count / numbers.GetLength(0);
                }
                //PrintArray(averagecolums);
                Console.WriteLine($"Среднее арифметическое каждой из {averagecolums.Length} колонок:");
                for (int i = 0; i < averagecolums.Length; i++)
                {
                    Console.Write($"Колонка {i + 1}: {Math.Round(averagecolums[i], 2)} ");
                }
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
}
