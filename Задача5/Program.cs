// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

var Mon = "Понедельник";
var Tue = "Вторник";
var Wen = "Среда";
var Thu = "Четверг";
var Fri = "Пятница";
var Sat = "Суббота";
var Sn = "Воскресенье";

Console.WriteLine("Введите день недели");

var input = int.Parse(Console.ReadLine());
{
    if (input > 5 && input < 8)
    {
        System.Console.WriteLine("Да, выходной");
    }
    else if (input < 5)
    {
        System.Console.WriteLine("Нет, рабочий");
    }
    else
    {
            System.Console.WriteLine("Введите корректное значение");
    }
}