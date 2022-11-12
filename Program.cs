/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] RandomIntNumbersArray()
{
    Console.WriteLine();
    Console.Write("Введите количество строк массива случайных целых чисел: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите количество столбцов массива случайных целых чисел: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] Num = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Num[i, j] = new Random().Next(0, 10);
        }
    }
    return Num;
}

void MinRowSumSearch(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int CurrRowSum = 0;
    int MinRowSum = 0;
    int MinRowSumIndex = 0;
    for (int j = 0; j < y; j++)
    {
        MinRowSum += array[0, j];
    }
    for (int i = 0; i < x; i++)
    {
        CurrRowSum = 0;
        for (int j = 0; j < y; j++)
            CurrRowSum += array[i, j];
        if (CurrRowSum < MinRowSum)
        {
            MinRowSum = CurrRowSum;
            MinRowSumIndex = i;
        }
    }
    System.Console.Write($"Наименьшая сумма элементов - в {MinRowSumIndex + 1}-й строке.");
    System.Console.WriteLine();
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    System.Console.WriteLine();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", array[i, j]);
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] massiv = RandomIntNumbersArray();
PrintArray(massiv);
MinRowSumSearch(massiv);