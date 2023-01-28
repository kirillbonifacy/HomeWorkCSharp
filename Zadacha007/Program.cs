// Показать вторую цифру трёхзначного числа
Console.Write("Введите трёх значное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3)
{
    Console.WriteLine("Введено не верное число!");
}
else
{
    Console.WriteLine($"Второе число: {n[1]}");
}
