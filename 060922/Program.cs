

// Console.Write("Введите координату по оси Х: ");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0) Console.WriteLine("1 четверть");
// else if (X < 0 && Y > 0) Console.WriteLine("2 четверть");
// else if (X < 0 && Y < 0) Console.WriteLine("3 четверть");
// else if (X > 0 && Y > 0) Console.WriteLine("4 четверть");

// // Напишите программу, которая по 
//заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой 
//четверти (x и y).

// Console.WriteLine("Введите номер честверти: ");
// int quater = Convert.ToInt32(Console.ReadLine());
// if (quater == 1) Console.WriteLine("X>0 && Y>0");
// else if (quater == 2) Console.WriteLine("X<0 && Y>0");
// else if (quater == 3) Console.WriteLine("X<0 && Y<0");
// else if (quater == 4) Console.WriteLine("X>0 && Y>0");
// else Console.WriteLine("Ошибка, такой четверти нет");

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// d = √ ((x2-x1)^2+ (y2-y1)^2

// Console.Write("Введите координату Х1: ");
// int X1=Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату Y1: ");
// int y1=Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату Х2: ");
// int x2=Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату Y2: ");
// int y2=Convert.ToInt32(Console.ReadLine());

// double d=Math.Sqrt(Math.Pow(x2-X1, 2) + Math.Pow(y2-y1, 2));
// Console.WriteLine($"Расстояние между точками : {Math.Round(d,3)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// int start =1;
// Console.WriteLine("Укажите значение N квадрата");
// int end = Convert.ToInt32(Console.ReadLine());
// while (start <= end)
// {
//     Console.WriteLine(start*start);
//     start++;
//

int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную которую возводим в квадрат");
for (int start = 1; start <=end; start++)
{
    Console.WriteLine(start*start);
}