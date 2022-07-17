// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Generate2dimDoubleArray(int row, int column, int minValue, int maxValue)
// {
//     double[,] result = new double[row, column];
//     Random rand = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             result[i, j] = rand.Next(minValue, maxValue + 1) + rand.NextDouble();
//             result[i, j] = Math.Round(result[i, j], 1);
//         }
//     }
//     return result;
// }
// void Print2dimDoubleArray(double[,] doubleArray)
// {
//     for (int row = 0; row < doubleArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < doubleArray.GetLength(1); column++)
//         {
//             Console.Write($"{doubleArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = Generate2dimDoubleArray(m, n, -100, 100);
// Print2dimDoubleArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

// int[,] Generate2dimArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] result = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void Print2dimArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rowNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columnNum = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Generate2dimArray(rowNum, columnNum, -100, 100);
// Print2dimArray(myArray);
// Console.Write("Введите индекс элемента в массиве (строка): ");
// int userRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс элемента в массиве (столбец): ");
// int userColumn = Convert.ToInt32(Console.ReadLine());
// if(userRow < rowNum || userColumn < columnNum){
//     int userElement = myArray[userRow, userColumn];
//     Console.WriteLine($"Значение запрашиваемого элемента: {userElement}");
// }
// else{
//     Console.WriteLine("Такого элемента в заданном массиве нет");
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Generate2dimArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void Print2dimArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row,column]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columnNum = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Generate2dimArray(rowNum, columnNum, -100, 100);
Print2dimArray(myArray);

double findAverage (int[,] array, int column)
{
double sum = 0;
double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,column];
        average = sum / array.GetLength(0);
    }
    average = Math.Round(average,1);
    return average;
}

Console.Write($"Среднее арифметическое каждого столбца: ");
for (int tempColumn = 0; tempColumn < columnNum; tempColumn++)
{
    double averageColumn = findAverage(myArray, tempColumn);
    Console.Write($"{averageColumn}; ");
}
Console.WriteLine();