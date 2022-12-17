// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int lines = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] matrixA = new int[lines, columns];
int[,] matrixB = new int[lines, columns];
int[,] matrixRes = new int[lines, columns];
FillArray(matrixA);
PrintArray(matrixA);
WriteLine();
FillArray(matrixB);
PrintArray(matrixB);
WriteLine();


for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixRes[i, j] = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixRes[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
PrintArray(matrixRes);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
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