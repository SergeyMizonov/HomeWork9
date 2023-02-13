// Урок 9. Рекурсия
// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int count = 1;
// NaturalToLow(number, count);


// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count + 1);
//         Console.Write(count + " ");
//     }
// }


//  Задача 66: Задайте значения M и N. Напишите программу, 
//  которая найдёт сумму натуральных элементов 
//  в промежутке от M до N.

 
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
