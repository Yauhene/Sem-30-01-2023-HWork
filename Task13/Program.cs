// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.Write("Введите число, пожалуйста: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    if (number > 99)
    {
        int thirdDigit = 0;
        thirdDigit = number;

        for (int i = 1; i <= 2; i++)
        {
            thirdDigit = thirdDigit / 10;
        }
    
        thirdDigit= thirdDigit % 10;
        Console.WriteLine("Третьей цифрой с конца числа " + number + " является " + thirdDigit);
    }
    else Console.WriteLine("Введенное число не является трехзначным и выше");
}

else Console.WriteLine("Введенное значение не является целым числом");

Console.WriteLine(" ");
Console.WriteLine(" ");

