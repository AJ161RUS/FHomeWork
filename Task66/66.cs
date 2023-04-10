/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m, n;
Console.Write($"Введите М: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine(), out n);

int sum= 0;

Console.Write(SumNumbers(m, n, sum));

string SumNumbers(int m, int n, int sum)
{
    if (m > n)
        return $"{sum}";
         sum = sum + m ++ ;
            return $"{sum}, -> {SumNumbers( m, n, sum)}";
           
}
