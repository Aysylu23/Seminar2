﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число:");
string? str = Console.ReadLine();
int number = Convert.ToInt32(str);


if ( number <= 5) 
{ 
    Console.WriteLine("Нет");
}
if ( number == 6 || number == 7) 
{
    Console.WriteLine("Да");
}
if (number >= 8)
{
    Console.WriteLine("В неделе 7 дней");
}




