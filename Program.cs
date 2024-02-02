﻿using System;

class SortNumbers
{
    static void Main(string[] args)
    {
        int[] numbers = { 61, 76, 32, 57, 66, 73, 67, 58, 33, 34, 52, 95, 96, 90, 53, 35, 1, 10, 12, 77, 39, 40, 13, 2, 24, 25, 62, 91, 92, 63, 26, 3, 27, 28, 64, 65, 29, 4, 78, 30, 74, 75, 31, 5, 93, 94, 79, 14, 15, 16, 17, 6, 80, 41, 54, 84, 55, 88, 56, 42, 85, 43, 7, 44, 45, 8, 18, 19, 20, 83, 46, 86, 47, 21, 68, 22, 48, 87, 49, 23, 9, 36, 37, 38, 81, 50, 99, 69, 51, 59, 89, 60, 70, 98, 71, 72, 82, 11, 97, 100 };
        Console.WriteLine("Список значений: " + String.Join(", ", numbers));

        Sort(numbers);
        Console.WriteLine("Отсортированный список: " + String.Join(", ", numbers));
    }

    static void Sort(int[] array)
    {
        bool swapped;
        for (int i = 0; i < array.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            // Если на каком-то проходе не было обменов, массив отсортирован
            if (!swapped)
                break;
        }
    }
}