Console.WriteLine("Введите количество значений в массиве");
int countMas = int.Parse(Console.ReadLine());
int[] mas = new int[countMas];

RandomMas(mas);
PrintMas(mas);
Console.WriteLine($"Сумма нечетных чисел в массиве: {CheckMas(mas)}");

int CheckMas(int[] mas)
{
    int resut = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 != 0)
        {
            resut += mas[i];
        }
    }
    return resut;
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}

void RandomMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-100, 100);
    }
}