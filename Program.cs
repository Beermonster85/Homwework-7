// Задача №1
// Задайте двумерный массив размером m x n, заполненный случайными целыми числами.
// m = 3  n = 4
// 1 4 8 1 9
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите число №1");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число №2");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLongLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// Homework

// Задание №1
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число №1");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число №2");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLongLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-99, 99) / 10.0;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }


// Задание №2
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i, j] + "\t  ");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите координаты");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > m && b > n)
//     Console.WriteLine("такого числа нет");
// else
// {
//     object c = array.GetValue(a, b);
//     Console.WriteLine(c);
// }


// Задание №3
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();