// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 6)
{
    Console.WriteLine($"Нет");
}
else
{
    Console.WriteLine($"Да");
}

