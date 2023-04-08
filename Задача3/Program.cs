// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета (решать только при помощи операций % и /).

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.Write("Укажите числа > ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);
if(number < 1000 && number > 99)
{
    int result = ( number % 100 - number % 10 )/10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Введите трехзначное число");
}