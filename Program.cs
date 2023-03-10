//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7

// Console.WriteLine("Введите первое  число");
// int num1 = Convert.ToInt32 (Console.ReadLine() );
// Console.WriteLine("Введите второе  число");
// int num2 = Convert.ToInt32 (Console.ReadLine() );
// if (num1<num2)
// {
//     Console.Write("Максимальное число ");
//     Console.Write(num2);
//     Console.Write(", Минимальное число ");
//     Console.Write(num1);
// }

// else
// {
//     Console.Write("Максимальное число ");
//     Console.Write(num1);
// Console.Write(", Минимальное число ");
//     Console.Write(num2);
// }

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