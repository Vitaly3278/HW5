// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double DoubleArray(int len)
{
    double[] array = new double[len];
    double max = 0;
    double min = 1;
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        Console.WriteLine($"{array[i]} ");
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}
Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

double diff = DoubleArray(len);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
