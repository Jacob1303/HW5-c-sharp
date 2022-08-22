//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Programm
{
    static void CreatArray(double[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            numbers[i] = new Random().Next(-50, 50);
            Console.Write(numbers[i] + "; ");
        }
        numbers[numbers.Length - 1] = new Random().Next(-50, 50);
        Console.WriteLine(numbers[numbers.Length - 1] + ".");
    }
   
    static void Main(string[] args)
    {
        double[] array = new double[10];
        CreatArray(array);
        double SubtMaxMin = array.Max() - array.Min();
        Console.WriteLine("Разница между максимальным и минимальным значениями массива = " + SubtMaxMin);
    }

}