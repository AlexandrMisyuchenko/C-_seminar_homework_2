// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine(" Введиье трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100 )
{
  Console.WriteLine(" Не трехзначное число !!! ");
  return;
}
else
{
    int remains = number % 100; // остаток 56
    int secondDigit = remains / 10; //второеичисло от number =5
    Console.WriteLine (secondDigit);
}
