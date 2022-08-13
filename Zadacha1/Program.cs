
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string inputNumber = Console.ReadLine();

if (inputNumber.Length != 5)  Console.Write("Ошибка");
else
{
    if (inputNumber[0] == inputNumber[4] && inputNumber[1] == inputNumber[3])   Console.Write($"Число {inputNumber} является палиндромом");
    else Console.Write($"Число {inputNumber} НЕ является палиндромом");
}