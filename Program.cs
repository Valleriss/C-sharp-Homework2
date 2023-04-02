// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
int SecondDigit = (N / 10) % 10;


if (N > 99 & N < 1000){
    Console.WriteLine($"Вторая цифра {SecondDigit}");
}
else{
    Console.WriteLine("Это не трёхзначное число");
}