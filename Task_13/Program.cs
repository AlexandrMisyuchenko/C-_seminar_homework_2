// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(" Введите число ");
string stringNumber = Console.ReadLine();

int number;
bool isNumber = int.TryParse (stringNumber, out number);

if (isNumber)
{
    if ( number < 100 )
    {
        Console.WriteLine(" Третьей цифры нет !!! ");
        return;
    }
    else 
    {
       int thirDigit = int.Parse(Convert.ToString(number)[2].ToString());
        Console.WriteLine(thirDigit);
    }
}
else
{
    Console.WriteLine(" В строчке присутствуют буквы !! ");
}

