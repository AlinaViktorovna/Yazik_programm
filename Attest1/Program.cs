// Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

static void Nature (int M, int N)
{
    if (M > 0 && M >= N)
    {
    Console.Write (M);
    }
    else if (M > 0 && M <= N)
{
    Console.Write (M);
    
}
if (M > N)
    {
    Nature (M - 1, N);
    }
    else if (M < N)
    {
        Nature (M + 1, N);
    }
}
Nature (3, 9);