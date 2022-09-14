//Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int SumOdd(int len)
{
    int[] array = new int[len];
    int sum = 0;
    Console.Write("Ваш массив: ");
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

int summ = SumOdd(len);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {summ}");
