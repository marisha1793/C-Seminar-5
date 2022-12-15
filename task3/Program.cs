// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите массив из 4 случайных чисел: ");
double[] array = CreateRandomArray();
PrintArray(array);
double max = FindMaxElement(array);
double min = FindMinElement(array);
double dif = max - min;
Console.WriteLine(dif);

double FindMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

double[] CreateRandomArray()
{
    Random random = new Random();
    double[] array = new double [4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,100);
    }
    return array;
}