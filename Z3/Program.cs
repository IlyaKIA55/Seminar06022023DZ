﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];

void GArray(int [] array)
{
    int index = 0;
    Random random = new Random();
    while (index<array.Length)
    {
        array[index] = random.Next(1, 100);
        index++;
    }
}
GArray(array);
Console.WriteLine(string.Join(',',array));