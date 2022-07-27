// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8"

// // Вариант без рекурсии
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = M; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine();

// Вариант с рекурсией
// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecusiveType(start+1, end));
// }
// Console.Clear();
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(M, N));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Вариант без рекурсии
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum =0;
// for (int i = M; i <= N; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"{sum} ");

// // Вариант с рекурсией
// int FindSumRecusiveType(int start, int end)
// {
//     int sum = 0;
//     if (start == end)
//     {
//         return start;
//     }
//     else
//     {
//         sum = start + FindSumRecusiveType(start+1, end);
//         return (sum);
//     }
    
// }
// Console.Clear();
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSumRecusiveType(M, N));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

float Akkerman (float m, float n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return Akkerman (m - 1, 1);
    }
    else
        return Akkerman (m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
float M = float.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
float N = float.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(M, N));