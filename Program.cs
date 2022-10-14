// Урок 9. Как не нужно писать код. Часть 3

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите чилсло N: ");
// int n = int.Parse(Console.ReadLine()!);

// string recursion (int n) 
// {
// if(n==1)
// {
//     return "1";
// }
// return (n + ", " + recursion(n-1));
// }
// Console.WriteLine(recursion(n));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите чилсло M: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите чилсло N: ");
// int n = int.Parse(Console.ReadLine()!);

// int RecursSumm (int m, int n) 
// {
// if(m == n)
// {
//     return m;
// }
// return (m + RecursSumm(m + 1, n));
// }
// Console.WriteLine(RecursSumm(m, n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите чилсло M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите чилсло N: ");
int n = int.Parse(Console.ReadLine()!);
int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
   Console.WriteLine($" A({m}, {n}) = {recursion(m, n)}");

