// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myRandomArray = CreateRandomArray(num, 100, 999);
int quantity = 0;

for (int i = 0; i < num-1; i++)
{
    if(myRandomArray[i] % 2 == 0){
    quantity = quantity + 1;
    }
}

Console.Write($"Массив из {num} трехзначных чисел -> [ ");
showArray(myRandomArray);
Console.Write("]");
Console.WriteLine($" четных чисел в нем - {quantity}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void showArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.Clear();

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] myRandomArray = CreateRandomArray(num, 0, 999);
// int sum = 0;

// for (int index = 0; index < myRandomArray.Length; index++)
// {
//     if(index % 2 !=0){
//     sum = sum + myRandomArray[index];    
//     }
// }

// Console.Write($"Массив из {num} чисел -> [ ");
// showArray(myRandomArray);
// Console.Write("]");
// Console.WriteLine($" сумма элементов, стоящих на нечётных позициях = {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, int min, int max)
// {
//     double[] array = new double[size];
//             Random rand = new Random();
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = rand.Next(min, max+1) + rand.NextDouble();
//                 array[i] = Math.Round(array[i], 2);
//             }

//     return array;
// }
// void showArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.Clear();

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] myArray = CreateRandomArray(num, 0, 999);
// Console.Write($"Массив из {num} чисел -> [ ");
// showArray(myArray);
// Console.WriteLine("] ");

// int index = 0;
// double max = myArray[0];
// double min = myArray[1];

// if(myArray[1] > myArray[0]){
//     max = myArray[1];
//     min = myArray[0];
// }
// else{
// for (index = 0; index < myArray.Length; index++)
// {
//     if(myArray[index] >= max){
//         max = myArray[index];
//     }
//     else if(myArray[index] <= min){
//         min = myArray[index];
//     }
// }
// }
// double result = 0;
// result = max - min;
// result = Math.Round(result, 2);

// Console.WriteLine($"Максимальный элемент массива = {max}");
// Console.WriteLine($"Минимальный элемент массива = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом = {result}");