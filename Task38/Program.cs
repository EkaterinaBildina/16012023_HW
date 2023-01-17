// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.Write("] ");
}

double MaxElement(double[] arr)
{
    double maxElem = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[i + 1]) maxElem = arr[i];
        else maxElem = arr[i + 1];
    }
    return maxElem;

}

double MinElement(double[] arr)
{
    double minElem = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[i + 1]) minElem = arr[i];
        else minElem = arr[i + 1];
    }
    return minElem;
}

double[] array = CreateArrayRndInt(5, 0, 10);
PrintArray(array);

double maxElement = Math.Round(MaxElement(array), 1);
double minElement = Math.Round(MinElement(array), 1);

Console.WriteLine($"-> {Math.Round(maxElement - minElement,1)}");

Console.WriteLine($"For reference: (Max = {maxElement}, Min = {minElement})");



