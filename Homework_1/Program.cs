// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b) {
//     Console.WriteLine("-> max = " + a);
// }
// else {
//     Console.WriteLine("-> max = " + b);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b & a > c) {
//     Console.WriteLine("-> " + a);
// }
// else if  (b > a & b > c) {
//     Console.WriteLine("-> " + b);
// }
// else {
//     Console.WriteLine("-> " + c);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1 || number % 2 == -1) {
    Console.WriteLine("-> нет");
}
else {
    Console.WriteLine("-> да");
}


