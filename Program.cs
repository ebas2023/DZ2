﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456 -> 5
782 -> 8
918 -> 1*/

Console.Write($"Введите техзначное число: ");
int Num3=int.Parse(Console.ReadLine ()!);
string Num3S=Num3.ToString ();
if (Num3S.Length == 3) 
{
    Console.WriteLine(Nim3S[1]);
}
else
{
    Console.WriteLine ("Число введено некорректно");
}
