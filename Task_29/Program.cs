﻿//                          Задача 29:

// Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.Write(array[i]); 
        if (i < array.Length - 1) 
        { 
            Console.Write(", ");
        } 
    } 
} 

int[] myArr = FillArray(8);
PrintArray(myArr);