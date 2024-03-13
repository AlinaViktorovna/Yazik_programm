//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int [] n = {5, 4, 8, 1, 7, 9, 6, 2, 0, 3};
static void ArrayReverse(int[] n, int size)

{
    if (size <= n.Length)
    {
        Console.Write(n[n.Length - size]);
        ArrayReverse(n, size + 1);
    }
}
ArrayReverse(n, 1);