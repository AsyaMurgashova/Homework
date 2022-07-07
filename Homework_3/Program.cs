// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= -99999 & number < -9999 || number > 9999 & number <= 99999){
    int fifthDigit = number % 10;
    int fourthDigit = number / 10 % 10;
    int secondDigit = number / 10 / 10 / 10 % 10;
    int firstDigit = number / 10 / 10 / 10 / 10 % 10;
    if(fifthDigit == firstDigit && fourthDigit == secondDigit){
        Console.WriteLine(number + " является палиндромом");
    }
    else{
         Console.WriteLine(number + " не является палиндромом");
    }
}
else{
    Console.WriteLine("Число не пятизначное, введите другое число");
}



// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Coordinates( int x1, int y1, int z1, int x2, int y2, int z2){
// return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
// }

// Console.Write("Введите координату точки А по оси X: ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки A по оси Y: ");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки A по оси Z: ");
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси X: ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Z: ");
// int Bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Coordinates(Ax, Ay, Az, Bx, By, Bz));



// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.

// Console.Write("Введите число N:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица кубов чисел от 1 до " + number);
// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine(i + " => " + i*i*i);
// }