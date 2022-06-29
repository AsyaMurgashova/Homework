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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = number % 10;
if(number / 10 <= 9){
    Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine("-> " + thirdDigit);
}



// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int number = new Random().Next(10,100);
// // Console.Write(number);
// int num1 = number / 10;
// int num2 = number % 10;
// Console.WriteLine(number + " " + num1 + " " + num2);
// if (num1 > num2) {
//     Console.WriteLine(num1);
// }
// else {
//     Console.WriteLine(num2);
// }


// void randomNumber (){
// int number = new Random().Next(10,100);
// // Console.Write(number);
// int num1 = number / 10;
// int num2 = number % 10;
// Console.WriteLine(number + " " + num1 + " " + num2);
// if (num1 > num2) {
//     Console.WriteLine(num1);
// }
// else {
//     Console.WriteLine(num2);
// }
// }
// randomNumber();


// void randomNumber(int min, int max){
//     int number = new Random().Next(min,max+1);
//     Console.Write(number + " -> ");
//     if (number / 10 > number % 10) {
//         Console.WriteLine(number / 10);
//     }
//     else {
//         Console.WriteLine(number % 10);
//     }
// }

// Console.WriteLine("Введите минимальное число диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число диапазона: ");
// int end = Convert.ToInt32(Console.ReadLine());
// randomNumber(start, end);


// int SumTwoNumbers( int a, int b){
//     int sum = a + b;
//     return sum;
// }
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Сумма двух чисел: " + SumTwoNumbers(number1, number2));