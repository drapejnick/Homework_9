// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

public class Program
{
    public static void Main()
    {
        void PrintInterval(int m, int n)
        {
            int start = n;
            int end = m;
            if (m > n)
            {
                start = n;
                end = m;
            }
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
        PrintInterval(5, 1);

        Console.WriteLine();
    }
}
