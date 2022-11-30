/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки,
 вторая - столбца.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int[,] array = new int[6, 6];
int a = GetIndex("Введите номер строки: ");
int b = GetIndex("Введите номер столбца: ");

int GetIndex(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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

FillArray(array);
PrintArray(array);
PrintAnswer(a, b);

void PrintAnswer(int line, int column)
{
    if (line <= 6 && column <= 6)
    {
        Console.WriteLine($"{line}{column} -> {array[line, column]}");
    }
    else
    {
        Console.WriteLine($"{line}{column} -> такого числа в массиве нет");
    }
}