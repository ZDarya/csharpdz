// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{ 
    Console.WriteLine("Первое число больше второго");
}
if (number1 < number2)
{ 
    Console.WriteLine("Второе число больше первого");
}
if (number1 == number2)
{ 
    Console.WriteLine("Числа равны");
}