//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 =  int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 =  int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int number3 =  int.Parse(Console.ReadLine()!);
if (number2<number1)
{
    if(number3<number1)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
else
{
    if (number2<number3)
    {
        Console.WriteLine(number3);
    }
    else
    {
        Console.WriteLine(number2);
    }
}