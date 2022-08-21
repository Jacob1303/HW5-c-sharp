// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите кол-во элеметов массива. Массив будет состоять из положительных целых чисел, полученных в случайном порядке, в интервале от 1 до 30");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
Console.Write("Ваш массив ");
for (int i = 0; i < array.Length - 1; i++)
{
    array[i] = new Random().Next(1, 30);
    array[array.Length - 1] = new Random().Next(1, 30);
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[array.Length - 1] + ".");

int flag = array.Length % 2;

if (flag == 0)
{
    int[] array1 = new int[array.Length / 2];
    Console.Write("Результат перемножения элементов массива ");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = array[i] * array[array.Length - 1 - i];
        Console.Write(array1[i] + ", ");
    };
}
else
{
    int[] array1 = new int[array.Length / 2 + 1];
    Console.Write("Результат перемножения элементов массива ");
    for (int i = 0; i < array.Length / 2; i++)
    {
        array1[i] = array[i] * array[array.Length - 1 - i];
        array1[array.Length / 2] = array[array.Length / 2];
        Console.Write(array1[i] + ", ");
    };
    Console.WriteLine(array1[array.Length / 2] + ".");
}
