/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Если решаете математически максимум берем 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int Num3=int.Parse(Console.ReadLine ()!);
string Num3S=Num3.ToString ();
if (Num3S.Length > 2) 
{
    Console.WriteLine(Num3S[2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}
