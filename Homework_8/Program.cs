// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
// int[,] myArray = Generate2dimArray(rowNum, columnNum, 0, 100);
// Print2dimArray(myArray);


// void SortArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int t = j+1; t < inArray.GetLength(1); t++)
//             {
//                 if (inArray[i,t] > inArray[i,j])
//                 {
//                     int temp = inArray [i,j];
//                     inArray[i,j] = inArray[i,t];
//                     inArray[i,t] = temp;
//                 }
//             }
//         }
//     }
// }
// Console.WriteLine();
// SortArray(myArray);
// Print2dimArray(myArray);





// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Generate2dimArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] result = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//         result[i, j] = new Random().Next(minValue, maxValue + 1);
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
//             Console.Write($"{inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int GetMinimalSumRowNumber(int [,] array)
// {
//     int row = 0;
//     int minimalSum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minimalSum = minimalSum + array[0,1];
//     }
//     for (int i = 1; i < array.GetLength(1); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (minimalSum > sum)
//         {
//             minimalSum = sum;
//             row = i;
//         }
//     }
//     return row;
// }

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rowNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columnNum = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Generate2dimArray(rowNum, columnNum, 1, 10);
// Print2dimArray(myArray);
// Console.WriteLine($"Строка с наименьшей суммой - {GetMinimalSumRowNumber(myArray)}");

// // Работающий цикл по нахождению суммы строки (для проверки)
// int sumElements = 0;
// int minimalSum = 0;
// int[] SumArray = new int[rowNum];
// for (int i = 0; i < myArray.GetLength(0); i++)
// {  
//     sumElements = 0;  
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         sumElements = sumElements + myArray[i, j];
//     }
//     Console.WriteLine($"Сумма элементов строки {i} равна {sumElements}");
//     SumArray[i] = sumElements;
// }





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] Generate2dimArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] result = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//         result[i, j] = new Random().Next(minValue, maxValue + 1);
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
//             Console.Write($"{inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
//             }   
//         }
//     }
//     return arrayC;
// }

// Console.Clear();

// Console.Write("Введите количество строк первой матрицы: ");
// int rowNumA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int columnNumA = Convert.ToInt32(Console.ReadLine());
// int[,] arrayA = Generate2dimArray(rowNumA, columnNumA, 1, 10);
// Print2dimArray(arrayA);
// Console.WriteLine("-------------------");
// Console.Write("Введите количество строк второй матрицы: ");
// int rowNumB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int columnNumB = Convert.ToInt32(Console.ReadLine());
// int[,] arrayB = Generate2dimArray(rowNumB, columnNumB, 1, 10);
// Print2dimArray(arrayB);
// Console.WriteLine("-------------------");

// if (columnNumA != rowNumB)
// {
//     Console.WriteLine("Количество строк в 1 матрице не совпадает с количеством строк во 2 матрице. Введите корректные значения");
// }

// Print2dimArray(GetMultiplicationMatrix(arrayA, arrayB));





// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Generate3dimArray(int size1, int size2, int size3, int minValue, int maxValue)
// {
//     int[,,] result = new int[size1, size2, size3];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//                 int element = new Random().Next(minValue, maxValue + 1);
//                 if (FindElement(result,element)) continue;
//                 {
//                     result[i,j,k] = element;
//                 }
//             }
//         }
//     }
//     return result;
// }

// void Print3dimArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//             {
//                 Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k})  ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i,j,k] == el)
//                 {
//                     return true;
//                 }
//             }
//         }
//     }
//     return false;
// }

// Console.Clear();
// Console.Write("Введите размер массива 1: ");
// int size1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер массива 2: ");
// int size2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер массива 3: ");
// int size3 = Convert.ToInt32(Console.ReadLine());
// int[,,] result = Generate3dimArray(size1, size2, size3, 0, 100);
// Print3dimArray(result);




// Задача 62: Заполните спирально массив 4 на 4.

int [,] GenerateArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size - 1;
    int columnE = size - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        result[i,j] = count;
        // right direction
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        // down direction
        if(!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        // left direction
        if (!left && !top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
            }
        }
        // up direction
        if (left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] spiral = GenerateArray(size);
PrintArray(spiral);