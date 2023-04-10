/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m;
int n;
Console.Write($"Введите М: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write(AckermanF(m, n));

int AckermanF(int m,int  n)
{
    if (m == 0)
         return n + 1;
     if (m != 0 && n == 0 )
     return AckermanF(m - 1, 1);
     if (m > 0 && n > 0)
     return AckermanF(m - 1,AckermanF(m, n-1));
   return AckermanF( m, n);
}

Console.WriteLine($" Функуия Акермана для чисел {m}, {n} = {AckermanF(m, n)}");