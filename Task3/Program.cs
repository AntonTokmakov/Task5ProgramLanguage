Console.WriteLine("Введите количество значений в массиве");
int countMas = int.Parse(Console.ReadLine());
double[] mas = new double[countMas];

RandomMas(mas);
PrintMas(mas);
Console.WriteLine($"Колличество четных чисел в массиве: {CheckMas(mas)}");

double CheckMas(double[] mas)
{
    double result = 0, max = int.MinValue, min = int.MaxValue;
    for (int i = 0; i < mas.Length; i++)
    {
        if (max < mas[i])
        {
            max = mas[i];
        }
        if (min > mas[i])
        {
            min = mas[i];
        }
    }
    Console.WriteLine($"Максимальное число: {max} \n Минимальное число: {min}");
    result = max - min;
    return result;
}

void PrintMas(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}

void RandomMas(double[] mas)
{
    Random rand = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 2);
    }
}