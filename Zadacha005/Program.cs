// Показать четные числа от 1 до N
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int i = 1;
bool no = true;

Console.Write($"Чётные числа от 1 до {a}: ");
while (i <= a)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        no = false;
    }
i = i + 1;
}

if (no == true)
{
    Console.WriteLine("Нет чётных чисел!");
}