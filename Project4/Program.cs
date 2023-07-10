Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
for (int x = -num; x <= num; x++)
{
    Console.Write(x + " ");
}