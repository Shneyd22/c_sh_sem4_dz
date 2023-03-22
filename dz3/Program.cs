﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
FillArray(array);
PrintArray(array);




void FillArray(int[] array)
{
    for(int i = 0; i<8; i++)
    {
        array[i]=new Random().Next(0,100);
    }
}

void PrintArray(int[] array)
{
    foreach (int index in array)
    {
        Console.Write($"{index} ");
    }
}