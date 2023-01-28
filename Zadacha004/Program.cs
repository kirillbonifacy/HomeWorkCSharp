// Выяснить является ли число чётным
Console.WriteLine("Введите число для проверки чётности: ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}