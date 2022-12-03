/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

int row = 3;
int column = 4;
int[,] array = new int[row, column];
int sum = 0;
double avg = 0;


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (column = 0; column < array.GetLength(1); column++)
{
    for (row = 0; row < array.GetLength(0); row++)
    {
        sum += array[row, column];
        avg = Convert.ToDouble(sum) / Convert.ToDouble(array.GetLength(0));
    }
    Console.Write(Math.Round(avg, 1) + " ");
    sum = 0;
}


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]} ");
        }
        Console.WriteLine();
    }

}