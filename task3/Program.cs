﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ведите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number > 5)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}