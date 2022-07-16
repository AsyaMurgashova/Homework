// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] GenerateUsersArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите число {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Console.Clear();
// Console.Write($"Введите количество элементов в массиве: ");
// int userSize = Convert.ToInt32(Console.ReadLine());
// int[] userArray = GenerateUsersArray(userSize);
// int count = 0;

// for (int index = 0; index < userSize; index++)
// {
//     if(userArray[index] > 0){
//     count = count + 1; 
//     }
// }

// if(count == 0){
//     Console.WriteLine("Среди заданных чисел нет чисел больше нуля");
// }
// else{
//     Console.WriteLine($"Вы ввели {count} чисел больше нуля");
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
// // ДЗ  x = (b2 -b1)/(k1 - k2), y = k2 * x + b2

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

if(k1 == k2){
    if(b1 == b2){
        Console.WriteLine("Прямые совпадают");
    }
    else{
    Console.WriteLine("Точек пересечения нет"); 
    } 
} 
else{
    x = (b2 - b1)/(k1 - k2);
    y = k2 * x + b2;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine($"Координаты точки пересечения прямых: {x},{y}");
}
