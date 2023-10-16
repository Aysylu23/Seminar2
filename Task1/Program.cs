//Напишите программу, котрая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа


int minNumber = 10;
int maxNumber = 99; 

int randomNumber = new Random().Next(minNumber, maxNumber + 1);
int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;
int max = firstDigit;
if(max < secondDigit)
{
    max = secondDigit;
}

Console.WriteLine($"{randomNumber} -> {max}");

// && - и
// || - или
/*string name = "Denis";
char symbol = name[0];
Console.WriteLine(symbol);

string numberString = "28";
int number*/
