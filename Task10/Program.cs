// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine();
Console.WriteLine();

Console.Write("Введите число, пожалуйста: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    int singleDigit=0;
    singleDigit=number;
    singleDigit=singleDigit/10;
    singleDigit=singleDigit%10;
    Console.WriteLine("Второй цифрой с конца числа " + number + " является " + singleDigit);

}

else Console.WriteLine("Введенное значение не является целым числом");

Console.WriteLine();
Console.WriteLine();