//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7

Console.WriteLine("Введите первое  число");
int num1 = Convert.ToInt32 (Console.ReadLine() );
Console.WriteLine("Введите второе  число");
int num2 = Convert.ToInt32 (Console.ReadLine() );
if (num1<num2)
{
    Console.Write("Максимальное число ");
    Console.Write(num2);
    Console.Write(", Минимальное число ");
    Console.Write(num1);
}

else
{
    Console.Write("Максимальное число ");
    Console.Write(num1);
Console.Write(", Минимальное число ");
    Console.Write(num2);
}

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7

// Console.WriteLine("Введите первое  число");
// int num1 = Convert.ToInt32 (Console.ReadLine() );
// Console.WriteLine("Введите второе  число");
// int num2 = Convert.ToInt32 (Console.ReadLine() );
// Console.WriteLine("Введите третье  число");
// int num3 = Convert.ToInt32 (Console.ReadLine() );
// int max =num1;
// if (max<=num2)
// max=num2;
// if (max<=num3)
// max=num3;
// Console.Write("Максимальное число ");
// Console.Write(max);


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).Например,
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите любое целое число");
// int num1 = Convert.ToInt32 (Console.ReadLine() );

// if (num1%2 ==0)
// {
// Console.Write("Введенное число "+num1+"- четное");
// }
// else 
// {
//     Console.Write("Введенное число "+num1+"- нечетное");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. Например,
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите любое целое число больше единицы(1)");
// int num = Convert.ToInt32 (Console.ReadLine() );
// int count=2;
// if (num<=1) 
// Console.WriteLine("Введенное число не больше единицы");
// while (count<num+1)
// {
// Console.Write(count+" ");
// count = count+2;
// }
// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа
// или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет
//  Console.WriteLine("Введите любое целое число");
//  int num = Convert.ToInt32 (Console.ReadLine() );
//  int divnum=num;
//  if (num<10)
// Console.WriteLine("Второй цифры нет");
// else if (num>9 && num<=100)
//      {

// Console.WriteLine(divnum % 10);
//      }
// else if (num>100)
// {
//     do 
//     {
//         divnum=divnum/10;
//     }
//     while (divnum>100);
//     Console.WriteLine(divnum % 10);
// }




// Cеминар 2 10.03.2023


// 1 версия задачи

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int num1 = num/100;
// int num2 = num % 10;
// Console.WriteLine($"{num1}{num2}");

// 2 версия задачи (готова). Условие - вводим число любой разрядности и удаляем из него вторую цифру

// int x = Convert.ToInt32(Console.ReadLine());
// int result = (int)Math.Floor(Math.Log(x, 10) + 1);
// int index = 3;
// if (result > 1)
// {

//     int digit = x / (int)Math.Pow(10, result - 1);
//     Console.Write(digit % 10);
//     do
//     {
//         int digit2 = x / (int)Math.Pow(10, result - index);
//         Console.Write(digit2 % 10);
//         index++;
//     }
//     while (index <= result);

// }

// else Console.WriteLine("Sorry, dude");

// Получаем любое число, выдаем сумму всех его цифр( НЕ ДОДЕЛАНА)
// Console.WriteLine("Введите любое целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// int result = (int)Math.Floor(Math.Log(x, 10) + 1);
// int index = 3;
// int sum=0;
// int digit = x / (int)Math.Pow(10, result - 1);
// while (index<result)
// {index++;
// sum=+digit%10;
// }
// Console.Write(sum);

// else Console.WriteLine("Sorry, dude");




// Console.WriteLine("Введите первое  число");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе  число");
// int num2= Convert.ToInt32(Console.ReadLine());
// int num3= num1%num2;
// if (num3==0)
//      Console.Write("Кратно");
// else 
//     Console.Write($"Не кратно, остаток  {num3}");


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%7 == 0 && num%23 == 0)
//     Console.Write("Кратно");
// else
//     Console.Write("Не кратно");


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
// Console.WriteLine("Введите первое  число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе  число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1*num1 == num2 || num2*num2 == num1) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Домашнаяя работа после 2 семинара
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите целое трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<100 | num>999) Console.WriteLine("Читаем первое условие внимательнее)");
// if (num>99 && num<1000) 
// Console.WriteLine("Вторач цифра числа ="+(num/10)%10);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//  Console.WriteLine("Введите положительное целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<100 ) Console.WriteLine("У введенного числа нет третьей цифры");
// else if (num<1000 && num>99 )
// {
// Console.WriteLine("Третья цифра заданного числа ="+num%10);
// }
// else if ( num>999)
// {do 
//     {
//         num=num/10;
//     }
//     while (num>999);
//     Console.WriteLine("Третья цифра заданного числа ="+num % 10);
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("Введите порядковый номер дня недели");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num==6 || num==7) Console.WriteLine("Это выходной день");
// else Console.WriteLine("Это не выходной день");
















// Первый пример из третьего семинара
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x, y);
// Console.WriteLine($" это четверть № {CheckKoord2(x,y)}");


// void CheckKoord(int x, int y)
// {
//     if (x > 0 && y > 0)
//         Console.WriteLine("Четверть № 1");
//     else if (x < 0 && y > 0)
//         Console.WriteLine("Четверть № 2");
//     else if (x < 0 && y < 0)
//         Console.WriteLine("Четверть № 3");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("Четверть № 4");
//     else
//         Console.WriteLine("Точка находится на координатной оси");
// }

// int CheckKoord2(int x, int y)
// {
//     int res = 0;
//     if (x > 0 && y > 0)
//         res = 1;
//     else if (x < 0 && y > 0)
//         res = 2;
//     else if (x < 0 && y < 0)
//         res = 3;
//     else if (x > 0 && y < 0)
//         res = 4;
//     return res;
// }





// Задача в группе - здесь выводили значения координат, соответствубщих введенной четверти. 
// Добавили try catch чтобы при вводе, например, слова, программа успешно завершалась и сообщала нам об ошибке

// try{
//     Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckQuat(num);
// Console.WriteLine(CheckQuat2(num));

// }
// catch{
//     Console.WriteLine("Нужно было ввести целое число");
// }


// void CheckQuat(int num)
// {
//     if (num==1)
//         Console.WriteLine("Координаты X>0 и Y>0");
//     else if (num==2)
//         Console.WriteLine("Координаты X<0 и Y>0");
//     else if (num==3)
//         Console.WriteLine("Координаты X<0 и Y<0");
//     else if (num==4)
//         Console.WriteLine("Координаты X>0 и Y<0");
//     else
//         Console.WriteLine("Введено некорректное значение");
// }

// string CheckQuat2(int num)
// {
//     string res = "Введено некорректное значение";
//     if (num==1)
//         res = "Координаты X>0 и Y>0";
//     else if (num==2)
//         res = "Координаты X<0 и Y>0";
//     else if (num==3)
//         res = "Координаты X<0 и Y<0";
//     else if (num==4)
//         res = "Координаты X>0 и Y<0";
//     return res;
// }




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//  Console.WriteLine("Введите ко");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Dist(x1, x2, y1, y2));


// double Dist(int x1, int x2, int y1, int y2)
// {

//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return result;

// }
// Усложненный вариант - не сделан
// Console.WriteLine("Введите, в каком пространстве будем искать расстояние");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Dist(x1, x2, y1, y2));

// int[] nums1 = new int[4] {Convert.ToInt32(Console.ReadLine())};

// double Dist(int x1, int x2, int y1, int y2,int N)
// {

//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return result;

// }

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Power(num);

// void Power(int num)
// {
// for (int i=1; i<=num; i++)
// {
//     Console.Write((i*i)+" ");
// }
// }