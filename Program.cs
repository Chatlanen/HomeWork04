// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System.Reflection.Metadata.Ecma335;

int m = -5;
int n = 10;

void getNatural(int m, int n){
    if (m > 0) Console.Write(m + " ");
    if (m == n) return;
    getNatural(m + ((m < n)? 1:-1), n);
}

getNatural(m,n);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

m = 2;
n = 1;

int a(int m, int n){
    if (m==0) return n +1;
    if (n == 0) return a(m - 1, 1);
    return a(m -1, a(m, n -1));
}

Console.WriteLine($"\nAkkerman ({m},{n}) = " + a(m, n));
