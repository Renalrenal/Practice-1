// Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

Console.Write("Укажите число > ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);
if(number <= 0)
{
    System.Console.WriteLine(number*-1);
}
else
{
    System.Console.WriteLine(number);
}