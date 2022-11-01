/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] arr = new int[0];
Random rand = new Random();
int min = int.MaxValue;
int max = int.MinValue;
int n = 0;

{
    Console.Write("Введите размер массива: ");
    n = int.Parse(Console.ReadLine());
    arr = new int[n];
    Console.Clear();
    Console.WriteLine("Нарандомленный массив:");

    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(0, 100);
        Console.Write("{0,5}", arr[i]);
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
    }
}
Console.WriteLine("min={0}", min);

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
}
Console.WriteLine("max={0}", max);
Console.WriteLine($"разница между max и min: {max - min}");
