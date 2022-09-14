// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] GetArray(int len)
{
    int[] array = new int[len];
    Console.Write("Ваш массив: ");
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = GetArray(len);

Console.Write("Новый массив: ");
int[] newarray = new int[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    newarray[i] = array[i] * array[(array.Length - 1) - i];
    Console.Write($"{newarray[i]} ");
}
if (array.Length % 2 != 0) // Если массив нечетный, добавляем среднюю цифру массива)
{
    Console.Write(array[array.Length / 2]);
}
