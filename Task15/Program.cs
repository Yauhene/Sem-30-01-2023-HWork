// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("Введите номер дня недели : ");
if(int.TryParse(Console.ReadLine(), out int i))
{
    switch (i)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    
    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        Console.WriteLine("Ура! ВЫХОДНОЙ !!!");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        Console.WriteLine("Ура! ВЫХОДНОЙ !!!");
        break;
    
    default:
        Console.WriteLine("Вы ввели некорректный номер дня недели");
        break;
}
}
else
{
    Console.WriteLine("Вы ввели не целое число");
}

Console.WriteLine(" ");
Console.WriteLine(" ");