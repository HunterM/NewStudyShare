// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int size = 12; // размер массива
// int[] array = new int[size]; // массив длиной size
// int resultPositive = 0; // сумма положительных чисел
// int resultNegative = 0;//сумма отрицательных

// for (int i = 0; i < array.Length; i++) //размер равен количеству элементов array.Length = size
// {
//     array[i] = new Random().Next(-9, 10); //[-9,9]
//     Console.Write(array[i] + "\t"); //"\t" - литерал ставит 4 пробела
//     if (array[i] > 0) resultPositive += array[i]; //
//     else resultNegative += array[i]; //сумма отрицательных чисел
// }
// Console.WriteLine();
// Console.Write("\n" + $"Positive: {resultPositive}, Negative: {resultNegative}"); //$ - форматирует текст "\n" -  пишет с новой строчки вместо


//Console.WriteLine();

// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5
 
 
// int[] array = new int[123];
// int count = 0;
// for (int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     if(array[i] >=10 && array[i] <=99 )
//     {
//         count++;
//     }
// }
 
// PrintIntArray(array);
// System.Console.WriteLine("\n" + count);
 
 
// void PrintIntArray(int[] array)
//         {
//             System.Console.Write($"[{array[0]}");
//             for (int i = 1; i < array.Length; i++)
//             {
//                 System.Console.Write($",\t{array[i]}");
//             }
//             System.Console.Write("]");
        // }
 
 
// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5
 
 
// int[] array = new int[123];
// int count = 0;
// for (int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     if(array[i] >=10 && array[i] <=99 )
//     {
//         count++;
//     }
// }
 
// PrintIntArray(array);
// System.Console.WriteLine("\n" + count);
 
 
// void PrintIntArray(int[] array)
//         {
//             System.Console.Write($"[{array[0]}");
//             for (int i = 1; i < array.Length; i++)
//             {
//                 System.Console.Write($",\t{array[i]}");
//             }
//             System.Console.Write("]");
//         }
 
 
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
 
// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i <size; i++)
// {
//     array[i] = new Random().Next(-10, 11);
 
// }
// PrintIntArray(array);
// System.Console.WriteLine();
// for (int i = 0; i < size; i++)
// {
//     array[i] *= -1;
// }
// PrintIntArray(array);
 
 
 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
 
// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i <size; i++)
// {
//     array[i] = new Random().Next(-10, 11);
// }
// PrintIntArray(array);
// System.Console.WriteLine();
// int number = Int32.Parse(Console.ReadLine());
 
// bool check = false;
 
// for (int i = 0; i < size; i++)
// {
//     if (array[i] == number)
//     {
//         check = true;
//         break;
//     }
// }
// if (check)
// {
//         System.Console.WriteLine("есть такое число!");
// }
// else{
//     System.Console.WriteLine("нет такого числа!");
// }
 
// int size = Int32.Parse(Console.ReadLine());
// int[] array = new int[size];
 
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0,10);
// }
// PrintIntArray(array);
// System.Console.WriteLine();
 
// int[] result = new int[size/2 + size%2];
// for (int i = 0; i < size/2 ; i++)
// {
//     result[i] = array[i] * array[^(i+1)]; // array[^2] == array[array.Length - 2]
// }
 
// System.Console.WriteLine(size/2 +1);
// if (size%2 !=0)
// {
//     result[size/2] = array[(size/2)];
// }
 
 
// PrintIntArray(result);

// задача 32

// int[] array = { -2, -1, 0, 1, 2 };

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= (-1); //array[i]  = array[i] * (-1)
//     Console.Write(array[i] + "\t");
// }


// int[] array = { -2, -1, 0, 1, 2 };
// int searchNumber = 3; // Число за рамкаками нашего массива
// bool flagResult = false; // false - элемент не найден, true - найден
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber)
//     {
//         
// flagResult = true; // Элемент найден
// break;
//         
//     }
// }
// // (flagResult == true) == if(flagResult)
// if (flagResult) Console.WriteLine($"Элемент {searchNumber} присутствует");
// else Console.WriteLine($"Элемент {searchNumber} отстутствует");


// int[] array = { -2, -1, 0, 1, 2 };
// int searchNumber = 100; // Число за рамкаками нашего массива
// string flagResult = "не найден"; 
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber)
//     {
//         flagResult = "найден"; // Элемент найден
//         break;
//     }
// }
// // (flagResult == true) == if(flagResult)
// Console.WriteLine($"Элемент {searchNumber}: {flagResult}");


// int size = 123;
// int[] array = new int[size];
// int count = 0; // Числа в диапазоне [10;99]

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1000); // [0,999]
//     Console.Write(array[i] + "\t");
//     if (array[i] >= 10 && array[i] <= 99) count++;
// }

// System.Console.WriteLine($"{"\n"}Количество чисел в диапазоне от 10 до 99:  {count}");



