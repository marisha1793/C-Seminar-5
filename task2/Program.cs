// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите массив из 4 случайных чисел: ");
int[] array = CreateRandomArray();
PrintArray(array);
int sum = GetSumOfOddPositionsInArray(array);
Console.WriteLine(sum);

int GetSumOfOddPositionsInArray(int[] array)
{
    int sum = 0;   
    for (int i = 0; i < array.Length; i++)
    {
        int remains = i % 2;
        if ( remains != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

int[] CreateRandomArray()
{
    Random random = new Random();
    int[] array = new int [4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-99,100);
    }
    return array;
}