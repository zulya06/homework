//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());

int min = number1;
int max = number2;

if (number1>max)
{
max = number1;
min = number2;
}

Console.WriteLine("max"+ max);
Console.WriteLine("min"+ min);
