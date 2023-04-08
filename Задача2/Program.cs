// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

Console.Write("Укажите число > ");
var a = double.Parse(Console.ReadLine());
double number = Convert.ToInt64(a);
double result = 1/number;
System.Console.WriteLine(result);