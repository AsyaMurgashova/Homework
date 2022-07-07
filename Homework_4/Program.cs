// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(number, degree));
Console.WriteLine($"{number}, {degree} -> {result}");



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// // int calculations(int N)
// // {
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int surplus = N % 10;
// while (surplus >= 9)
// {
//     surplus = (N - surplus) / 10;
// }

//     return surplus;
// }
// Console.WriteLine(surplus);



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GenerateArray(int N)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next();
//     }
//     return RandomArray;
// }

// void showArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// Console.WriteLine();
// Console.Clear();

// Console.Write("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = GenerateArray(num);
// Console.Write($"Массив из {num} случайных элементов -> [ ");
// showArray(myRandomArray);
// Console.WriteLine("]");
