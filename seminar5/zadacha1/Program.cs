/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Random rnd = new Random();

int num = rnd.Next(100, 999);
int num1 = rnd.Next(100, 999);
int num2 = rnd.Next(100, 999);
int num3 = rnd.Next(100, 999);

int[] mas = {num, num1, num2, num3};

int count = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 == 0)
        count++;
}
Console.WriteLine($"{num}, {num1}, {num2}, {num3}");
Console.WriteLine("Из рандомных чисел {0} четные", count);