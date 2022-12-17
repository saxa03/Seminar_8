// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int lines = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] matrix = new int[lines, columns];
FillArray(matrix);
PrintArray(matrix);
MinSumLines(matrix);

void MinSumLines(int[,] array) 
{
    int linesIndMin = 0;
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        linesIndMin += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i, j];
        if (sum < linesIndMin)
        {
            linesIndMin = sum;
            minSum = i;
        }
        sum = 0;
    }
    Write($"строка с наименьшей суммой елементов под номером: {minSum + 1} ");
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
}