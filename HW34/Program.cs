//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Programm
{
    static void CreatArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            numbers[i] = new Random().Next(100, 1000);
            Console.Write(numbers[i] + ", ");
        }
        numbers[numbers.Length - 1] = new Random().Next(100, 1000);
        Console.WriteLine(numbers[numbers.Length - 1] + ".");
    }

    static int CountEvenNnumb(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int[] array = new int[10];
        CreatArray(array);
        Console.WriteLine("Количество чётных элементов массива - " + CountEvenNnumb(array));
    }
}