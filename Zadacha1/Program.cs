// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int randomNumber = new Random().Next(1, 5);
System.Console.WriteLine(randomNumber);
string inputNumber = Convert.ToString(randomNumber);

if (inputNumber[1] == inputNumber[5] && inputNumber[2] == inputNumber[4])   Console.Write($"Число {inputNumber} является палиндромом");
else Console.Write($"Число {inputNumber} НЕ является палиндромом");
