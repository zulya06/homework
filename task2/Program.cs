﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number3");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine ("max"+ max);

