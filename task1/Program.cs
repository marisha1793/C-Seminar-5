// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите массив из 10 случайных трехзначных чисел: ");
int[] array = CreateRandomArray();
PrintArray(array);
int count = NumberOfEvenNumbersInArray(array);
Console.WriteLine(count);

int NumberOfEvenNumbersInArray(int[] array)
{
    int sum = 0;
   
        for (int i = 0; i < array.Length; i++)
    {
        int numberremains = array[i] % 2;
        if ( numberremains == 0)
        {
            sum = sum + 1;
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
    int[] array = new int [10];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
    return array;
}