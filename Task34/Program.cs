// Задача 34: 
// 1. Задайте массив 
// 2. заполненный случайными положительными трёхзначными числами. 
// 3. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("] ");
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int evenNum = arr[i] % 2;
        if (evenNum == 0) count++;
    }
    return count;
}


int[] array = CreateArrayRndInt(10, 100, 999); // (Length, min, max)
PrintArray(array);
int countEvenNumbers = CountEvenNumbers(array);
Console.Write($"-> {countEvenNumbers}");

