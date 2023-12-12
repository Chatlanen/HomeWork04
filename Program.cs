// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("\nЗадача 1:===============================");

int m = -5;
int n = 10;

void getNatural(int m, int n){
    if (m > 0) Console.Write(m + " ");
    if (m == n) return;
    getNatural(m + ((m < n)? 1:-1), n);
}

Console.Write($"Натуральные числа от {m} до {n}: ");
getNatural(m,n);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


// Начальная функция
// m = 2;
// n = 3;
// int a(int m, int n){
//     if (m == 0) return n + 1;
//     if (n == 0) return a(m - 1, 1);
//     return a(m -1, a(m, n -1));
// }

Console.WriteLine("\nЗадача 2:===============================");

// Приведенная к результату из примера
// Если при числа натуральные проверка на отрицательность не нужна. 
// Ни одна из веток не даст -1


m = 2;
n = 3;

int a(int m, int n){
    if (n == 0) return m + 1;
    if (m == 0) return a(1, n - 1);
    return a(a(m -1, n), n-1);
}

Console.WriteLine($"\nAkkerman ({m},{n}) = " + a(m, n));

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

Console.WriteLine("\nЗадача 3:===============================");

int [] arr = [1, 2, 5, 0, 10, 34];

void reverse (int [] arr){
    if (arr.Length > 1) reverse (arr.SubArray(1));
    Console.Write(arr[0] + " ");
    return;
}

Console.WriteLine($"\n{String.Join(" ",arr)}");
reverse(arr);

public static class ArrayExtensions
{
    public static T[] SubArray<T>(this T[] source, int index)
    {
        int length = source.Length -1;
        T[] result = new T[length];
        Array.Copy(source, index, result, 0, length);
        return result;
    }
}