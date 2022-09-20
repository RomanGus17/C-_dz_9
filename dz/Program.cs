//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

// int n = InputInt("Введите число начала диапазона ");
// int m = InputInt("Введите число конца диапазона ");

// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m - 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

/////////////////////////////////////////////////////////////////////////////////
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// int m = InputInt("Введите число начала диапазона ");
// int n = InputInt("Введите число конца диапазона ");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void PrintSum(int m, int n)
// {
//     Console.Write(Sum(m - 1, n));
// }

// int Sum(int m, int n)
// {
//     int result = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         result = m + Sum(m, n);
//         return result;
//     }
// }

// PrintSum(m, n);

/////////////////////////////////////////////////////////////////////////////////
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9