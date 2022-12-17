﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;

Clear();
int[,,] matrix3D = new int[2, 2, 2];
FillArray(matrix3D);
PrintIndex(matrix3D);


void PrintIndex(int[,,] matr)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
            Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] += count;
                count += 1;
            }
        }
    }
}
 
 
 