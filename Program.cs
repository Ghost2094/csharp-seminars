﻿// Task 2. Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

// Console.WriteLine("Введите первое число арабскими цифрами:");
// int number1  = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число арабскими цифрами:");
// int number2  = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2)
// {
//   Console.Write("Большее число:");
//   Console.WriteLine(number1);
//   Console.Write("Меньшее число:");
//   Console.WriteLine(number2);
// }
// else if(number1 < number2)
// {
//   Console.Write("Большее число:");
//   Console.WriteLine(number2);
//   Console.Write("Меньшее число:");
//   Console.WriteLine(number1);
// }
// else
// {
//   Console.WriteLine("Вы ввели одинаковые числа! Они равны!");
// }


// Task 4. Напишите программу, которая принимает на вход 
// три числа и выдает, максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число арабскими цифрами:");
int number1  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число арабскими цифрами:");
int number2  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число арабскими цифрами:");
int number3  = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(number1 >= number2)
{
  max = number1;
}
else if(number2 >= number3)
{
   max = number2;
}
else
{
  max = number3;
}

Console.Write("Большее число:");
Console.WriteLine(max);


// Task 6. Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли 
// оно на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет


// Task 8. Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
