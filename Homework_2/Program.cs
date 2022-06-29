// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = number / 10 % 10;
// if(number / 10 <= 9){
//     Console.WriteLine("Неверное число");
// }
// else{
//     Console.WriteLine("-> " + secondDigit);
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int thirdDigit = number % 10;
// if(number / 10 <= 9){
//     Console.WriteLine("Третьей цифры нет");
// }
// else{
//     Console.WriteLine("-> " + thirdDigit);
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int N = Convert.ToInt32(Console.ReadLine());
if( N > 7){
Console.WriteLine("неверное число");
}
else{
    if(N >= 1 & N <= 5){
    Console.WriteLine(N + " -> нет");
    }
    else if(N == 6 || N == 7){
    Console.WriteLine(N + " -> да");
    }
}

