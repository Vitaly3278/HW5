// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Even(int len)
{
    int[] array = new int[len];
    int count = 0;
    Console.Write("Ваш массив: ");
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

int count = Even(len);
Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве: {count}");
