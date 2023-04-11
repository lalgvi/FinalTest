// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string Promt(string str)
// {
//     Console.WriteLine(str);
//     string num = Console.ReadLine()!;
//     return num;
// }

// void PrintNumbersRec(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }

//     Console.WriteLine(n);

//     PrintNumbersRec(n - 1);
// }
// PrintNumbersRec(int.Parse(Promt("Введите число")));

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// string Promt(string str)
// {
//     Console.WriteLine(str);
//     string num = Console.ReadLine()!;
//     return num;
// }

// int PrintSumNum(int m, int n, int sum = 0)
// {
//     if (m > n)
//     {
//         return sum;
//     }

//     int result = PrintSumNum(m + 1, n, sum + m);
//     return result;
// }

// int m = int.Parse(Promt("Введите число"));
// int n = int.Parse(Promt("Введите число"));

// Console.WriteLine(PrintSumNum(m, n));

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ack(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }

//     if (m == 0)
//     {
//         return Ack(n - 1, 1);
//     }

//     return Ack(n - 1, Ack(n, m - 1));
// }
// Console.WriteLine(Ack(2,3));
// Console.WriteLine(Ack(3,2));