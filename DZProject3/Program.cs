// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int a = number1 % 2;
if (a == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}