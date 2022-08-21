// a*=a умножение числа на само себя
// a*=a+b сначала сложение, потом умноженние на а

// Задайте одномерный массив из 123 случайных чисел. Найти кол-во элементов
// массива, значения которых в отрезке от 10 до 99

int[] array = new int[123];
int i = 0;
int count = 0;
for (i = 0; i < array.Length-1; i++)
{
    array[i] = new Random().Next(0, 124);
    array[array.Length-1]= new Random().Next(0, 124);
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[array.Length-1] + ".");
for (i = 0; i < array.Length; i++)
{
    if (array[i] <= 99 && array[i] >= 10)
    {
        count++;
    }
}
Console.WriteLine(" Количество чисел от 10 до 99 в массиве = " + count);
