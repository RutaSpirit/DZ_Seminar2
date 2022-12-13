// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите k и b первой прямой: ");
string[] numbersFirst = Console.ReadLine().Split(" ");
double k1 = Convert.ToDouble(numbersFirst[0]);
double b1 = Convert.ToDouble(numbersFirst[1]);
Console.Write("Введите k и b второй прямой: ");
string[] numbersSecond = Console.ReadLine().Split(" ");
double k2 = Convert.ToDouble(numbersSecond[0]);
double b2 = Convert.ToDouble(numbersSecond[1]);
Console.WriteLine(Math.Round((b2 - b1) / (k1 - k2), 2));
Console.WriteLine(Math.Round(k2 * (b2 - b1) / (k1 - k2) + b2, 2));