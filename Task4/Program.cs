/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

/*Console.WriteLine("Введите  число");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);

if (number % 7 == 0 && number % 23 == 0) 
{
    Console.WriteLine("Число кратно");

}
 
else 
{
     Console.WriteLine("Число не кратно");
}*/











/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

/*Console.WriteLine("Введите  первое число");
string str1 = Console.ReadLine();
int number1 = Convert.ToInt32(str1);

Console.WriteLine("Введите  второе число");
string str2 = Console.ReadLine();
int number2 = Convert.ToInt32(str2);

if (number1 * number1 == number2 || number2 * number2 == number1) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}*/




Console.Write("Введите первое число: ");
string firstInput = Console.ReadLine();
int firstNumber = int.Parse(firstInput);
Console.Write("Введите второе число: ");
string secondInput = Console.ReadLine();
int secondNumber = int.Parse(secondInput);

if (firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}