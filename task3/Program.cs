//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int number;

Console.WriteLine("Input number1: ");
 number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine ("ваше число четное");
}
else
{
    Console.WriteLine ("ваше число нечетное");
}
