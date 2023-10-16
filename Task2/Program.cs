/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

/*Random randomizer = new Random();
int minNumber = 100;
int maxNumber = 999;

int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
int firstDigit = randomNumber / 100;
int thirdDigit = randomNumber % 10;

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine($"{randomNumber} -> {result}");*/

Random randomizer = new Random();
int minNumber = 100;
int maxNumber = 999;

int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
string randomNumberString = randomNumber.ToString();
string resultString = $"{randomNumberString[0]}{randomNumberString[2]}";
int result = int.Parse(resultString);

Console.WriteLine($"{randomNumber} -> {result}");


