// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
if (B < 0)
{
    Console.WriteLine("Введите чило B больше 0");
}
for (int i = 0; i <= B; i++)
{

    Console.WriteLine("A в степени B = " + Math.Pow(A, i));
}
Console.WriteLine();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите числ, сумму цифр которого необходимо посчитать ");
int numberNew = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberNew)
{

    int counter = Convert.ToString(numberNew).Length;
    int znachenie = 0;
    int sumChisel = 0;

    for (int i = 0; i < counter; i++)
    {
        znachenie = numberNew - numberNew % 10;
        sumChisel = sumChisel + (numberNew - znachenie);
        numberNew = numberNew / 10;
    }
    return sumChisel;
}

int sumNumber = SumNumber(numberNew);
Console.WriteLine();
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
Console.WriteLine();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Random myRandom = new Random();
Console.WriteLine("Случайный массив из 8 элементов: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 8);
    Console.Write("{0} ", array[i]);
}