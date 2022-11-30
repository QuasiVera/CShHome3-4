﻿// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями у = kx1 + b1 и у = kx2 + b2;
// значения k1, b1, k2, b2 задаются пользователем

double k1 = UserInput("Введите k1: ");
double b1 = UserInput("Введите b1: ");
double k2 = UserInput("Введите k2: ");
double b2 = UserInput("Введите b2: ");

string result = CrossPoint(k1, b1, k2, b2);

Console.Write($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} - > {result}");


//----------------Расчет точки пересечения прямых
string CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = Math.Round(((b2-b1)/(k1-k2)),3);
    double y = Math.Round((k1*x + b1),3);
    return $"точка пересечения ({x}; {y})";
}



//----------------Ввод данных
static double UserInput(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

