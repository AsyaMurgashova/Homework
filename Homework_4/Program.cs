// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант с циклом:
// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int degree = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= degree; i++)
// {
//     result = result * number;
// }
// Console.WriteLine($"{number}, {degree} -> {result}");

// Более удобный вариант (как мне кажется)

// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int degree = Convert.ToInt32(Console.ReadLine());
// int result = Convert.ToInt32(Math.Pow(number, degree));
// Console.WriteLine($"{number}, {degree} -> {result}");




// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int calculations(int N)
{
int surplus = 0;
int sum = 0;
while (N != 0)
{
    surplus = N % 10;
    sum = sum + surplus;
    N = N / 10;
}
return sum;
}
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех цифр -> " + calculations(number));



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
