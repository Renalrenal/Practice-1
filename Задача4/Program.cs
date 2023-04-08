// : Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета (решать только при помощи операций % и /).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool validateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьего числа нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число >");
if (validateNumber(number)) ;
{
    System.Console.WriteLine(GetThirdRank(number));
}