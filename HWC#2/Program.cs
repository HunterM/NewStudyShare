//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ПЕРВОЙ ЗАДАЧИ");
Console.WriteLine();
int numberA = new Random().Next(99, 1000);
int midleNumber = 0;
int HundridNum = 0;
Console.WriteLine("Случайное трехзначное число = " + numberA);
Console.WriteLine();
HundridNum = numberA / 100;
midleNumber = (numberA - (HundridNum * 100)) / 10;
Console.WriteLine("Вторая цифра трехзначного числа = " + midleNumber);
Console.WriteLine();


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine(">>>>>>>>>>>>РЕШЕНИЕ ВТОРОЙ ЗАДАЧИ");
Console.WriteLine();
int numberNew = new Random().Next(0, 100000);
Console.WriteLine("Случайное число = " + numberNew);
string str = numberNew.ToString();
//Console.WriteLine("Длина массива = " + str.Length);
Console.WriteLine();

//for (int i = 0; i < str.Length; i++)
if ( str.Length >=3)  
Console.WriteLine("Третья цифра числа = " + str[2]);
else
Console.WriteLine("Число не имеет третьего знака! Запусти программу еще раз.");
  //  if (str[i] >= 2)
//        Console.WriteLine("Третья цифра числа = " + str[2]);
Console.WriteLine();
//for (int i = 0; i <2; )
  //  if (str[i] < 2)
    //    Console.WriteLine("Число не имеет третьего знака! Запусти программу еще раз.");
//Console.WriteLine();
//for (int i = 0; i < str.Length; i++)
//if (i<2)
//Console.WriteLine("Число не трехзначное, попробуйте запустить программу еще раз!");
//else
//{
//Console.WriteLine("Число не трехзначное, попробуйте запустить программу еще раз!");
//}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

   