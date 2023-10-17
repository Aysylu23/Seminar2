/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Random randomizer = new Random();
int minNumber = 100;
int maxNumber = 999;

int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
string randomNumberString = randomNumber.ToString();
string resultString = $"{randomNumberString[1]}";
int result = int.Parse(resultString);

Console.WriteLine($"{randomNumber} -> {result}");
