//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ПЕРВОЙ ЗАДАЧИ");
Console.WriteLine();
int numberA = new Random().Next(0, 100000);
Console.WriteLine("Первое число = " + numberA);
Console.WriteLine();
int numberB = new Random().Next(0, 100000);
Console.WriteLine("Второе число = " + numberB);
Console.WriteLine();

int max = numberA;
int min = 0;
if (numberA > numberB) max = numberA; min = numberB;

if (numberB > numberA) max = numberB; min = numberA;

Console.WriteLine("Максимальное число = " + max);
Console.WriteLine();
Console.WriteLine("Минимальное число = " + min);
Console.WriteLine();



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ВТОРОЙ ЗАДАЧИ");
Console.WriteLine();
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
max = 0;
if (firstNumber > secondNumber && firstNumber > thirdNumber) max = firstNumber;
if (secondNumber > firstNumber && secondNumber > thirdNumber) max = secondNumber;
if (thirdNumber > secondNumber && thirdNumber > firstNumber) max = thirdNumber;
Console.WriteLine("Максимальное из введеных чисел = " + max);
Console.WriteLine();

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ТРЕТЬЕЙ ЗАДАЧИ");
Console.WriteLine();
Console.WriteLine("Введите число, которое хотите проверить на четность ");
Console.WriteLine();
int numberS = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (numberS % 2 == 0) 
    Console.WriteLine("Введеное число является четным");
else
    Console.WriteLine("Введеное число является НЕ четным");
Console.WriteLine();

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ЧЕТВЕРТОЙ ЗАДАЧИ");
Console.WriteLine();
Console.Write("Введите тестируемое число N ");
int testN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//number1 = 1;
for (int number1 = 2; number1 < testN; number1++)       
if (number1%2==0)            
Console.WriteLine(number1);