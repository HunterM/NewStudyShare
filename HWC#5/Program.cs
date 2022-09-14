// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine();
int size = 20;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000); // [100,999]
    Console.Write(array[i] + "\t");
    if (array[i] %2 ==0) count++;
}
Console.WriteLine($"{"\n"}Количество четных чисел в массиве:  {count}");
Console.WriteLine();
Console.WriteLine("++++++++++++++++++++++++++++");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine();
int sizeMassive = 12;
int[] arrayNew = new int[sizeMassive];
int resultSumm = 0;
for (int i = 0; i < arrayNew.Length; i++)
{
    arrayNew[i] = new Random().Next(100);
    Console.Write(arrayNew[i] + "\t");
    if (i %2 != 0) resultSumm += arrayNew[i]; 
}
Console.WriteLine();
Console.Write("\n" + $"Сумма НЕ ЧЕТНЫХ значений массива равна : {resultSumm}"); 
Console.WriteLine();
Console.WriteLine("++++++++++++++++++++++++++++");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine();
Random rnd = new Random();
int[] d = new int[10];
int max=0, min=100;
for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}
for (int i = 0; i < d.Length; i++) 
Console.Write("\t"+d[i]);
Console.WriteLine($"{"\n"}Максимальное значение: {max}");
Console.WriteLine($"{"\n"}Максимальное значение: {min}");
Console.WriteLine($"{"\n"}Разница между максимальным и минимальным значением: {max-min}");
Console.WriteLine("++++++++++++++++++++++++++++");
