/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int n, sum1 = 0;
Random rand = new Random();
int[] a;

{
    Console.Write("Введите размер массива: ");
    n = int.Parse(Console.ReadLine());
    a = new int[n];
    Console.Clear();
    Console.WriteLine("Нарандомленный массив:");
    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(0, 100);
        Console.Write("{0,5}", a[i]);
    }
    Console.WriteLine();
}

int count = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] % 2 == 0)
        count++;
}

Console.WriteLine("Из рандомных чисел {0} четные", count);