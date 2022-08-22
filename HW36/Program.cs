//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;

class Programm
{
    static void CreatArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            numbers[i] = new Random().Next(-50, 50);
            Console.Write(numbers[i] + ", ");
        }
        numbers[numbers.Length - 1] = new Random().Next(-50, 50);
        Console.WriteLine(numbers[numbers.Length - 1] + ".");
    }
    static int SumNumb(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int[] array = new int[10];
        CreatArray(array);
        Console.WriteLine("Сумма числе стоящих на нечётных позициях в массиве = " + SumNumb(array));
    }
}