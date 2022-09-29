// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
Console.Write("Введите значение элемента: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Элемент {number} {FindElement(number, array)}");
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} "); 
        }
        Console.WriteLine();       
    }
}
bool FindElement(int element, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element) return true;
        }
    }
    return false;
}