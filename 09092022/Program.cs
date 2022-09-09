// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int A = Convert.ToInt32(Console.ReadLine()); // правая граница
// int sum = 0; // Изначально переменная для суммы пустая
// for (int i = 1; i <= A; i++)
// {
//     sum += i; // sum = sum + i
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sumNumbers(number));
// int sumNumbers (int end)
// {
//     int sum =0;
//     for (int i = 1; i<=end; i++)
//     {
//         sum +=i;
//     }
//     return sum;
// }

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string number = Console.ReadLine();
// Console.WriteLine(number.Length);

// Console.Write("Введите число: ");
// int number= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(getCountNumbers(number));
// int getCountNumbers(int num) //переменная может называться как угодно
// {
//     int count = 0;
//     while (num >0 )
//     {
//         count++;
//         num/=10;
//     }
//     return count; //количество цифр в числе
// }

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine()); //глобальная переменная
// Console.WriteLine(getMultiply(N));
// int getMultiply (int N) //локальная переменная живет только в {}
// {
//     int result = 1;
//     for (int i=1; i<=N; i++)
//     {
//         result+=i;
//     }
//     return result;
// }



// Console.WriteLine(4, 7);
// Console.WriteLine(4, 6);
// int Calculate(int a, int b)
// {
//     return a+b;
// }


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int [] getArray (int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next();
//     }
//     return array;
// }
// int [] resultArray = getArray(8);

// Console.WriteLine($"Result Array : [{String.Join(", ", resultArray)}]");