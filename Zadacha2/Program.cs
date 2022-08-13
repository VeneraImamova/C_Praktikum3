// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату х1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1-X2, 2)+ Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2));

System.Console.WriteLine($"Расстояние равно: {Math.Round(d, 2)}");
// Console.WriteLine($"Расстояние = {d:f2}");