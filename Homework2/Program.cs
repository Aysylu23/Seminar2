/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine ("Введите число:");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);


Random randomizer = new Random();
int minNumber = 100;
int maxNumber = 999;

int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
string randomNumberString = randomNumber.ToString();
string resultString = $"{randomNumberString[0]}{randomNumberString[2]}";
int result = int.Parse(resultString);

Console.WriteLine($"{randomNumber} -> {result}");

