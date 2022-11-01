/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

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
        a[i] = rand.Next(-100, 100);
        Console.Write("{0,5}", a[i]);
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    if (i % 2 != 0)
        sum1 = sum1 + a[i];
}
Console.WriteLine("Сумма элементов с нечетными индексами {0}: ", sum1);
