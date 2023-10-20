// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write(" Введите номер дня недели:  ");

int numberOfDay;
string stringDay = Console.ReadLine();
bool siDay = int.TryParse(stringDay, out numberOfDay);
if (siDay)
{
    
    if (numberOfDay == 1)
    {
        Console.WriteLine($"{numberOfDay} -> Нет ");
    }
    else if (numberOfDay == 2)
    {
        Console.WriteLine($"{numberOfDay} -> Нет ");
    }
    else if (numberOfDay == 3)  
    {
        Console.WriteLine($"{numberOfDay} -> Нет ");
    }      
    else if (numberOfDay == 4)
    {   
        Console.WriteLine($"{numberOfDay} -> Нет ");
    }
    else if (numberOfDay == 5)
    {
        Console.WriteLine($"{numberOfDay} -> Нет ");
    }   
    else if (numberOfDay == 6)
    {
        Console.WriteLine($"{numberOfDay} -> Да ");
    }
    else if (numberOfDay == 7)
    {
        Console.WriteLine($"{numberOfDay} -> Да ");
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
}
else
{
    Console.WriteLine(" Нет такого дня недели ");
}


