﻿void Task47() 
{
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.");
Random random = new Random();
int rows = 4;
int columns = 5;
double [,] array = new double[rows, columns];
FillArrayDouble(array);
PrintArrayDouble(array);
}

void FillArrayDouble(double [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10, 1);
        }
    }
}

void PrintArrayDouble (double [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Task47();

void Task50() 
{
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Random random = new Random();
int rows = 4;
int columns = 5;
double [,] array = new double[rows, columns];
FillArrayDouble(array);
PrintArrayDouble(array);
PrintElementByInputIndex(array);
}
void PrintElementByInputIndex (double [,] array)
{
    Console.WriteLine("Введите номер строки");
    int inputRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int inputColumns = Convert.ToInt32(Console.ReadLine());
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (inputRows <= (rows + 1) && inputColumns <= (columns + 1))
    {
        Console.WriteLine ($"Значение элемента в строке {inputRows} столбца {inputColumns}: {array[inputRows-1, inputColumns-1]}");
    }
    else
    {
        Console.WriteLine ("Элемента с таким индексом нет в массиве");
    }
}
Task50();