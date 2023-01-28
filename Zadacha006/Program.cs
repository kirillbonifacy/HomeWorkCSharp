// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
double a = double.Parse(Console.ReadLine()!);

if (100 <= a && a <= 999)    // Проверка на трёхзначность!
{
    System.Console.WriteLine($"Последняя цифра числа {a} это {a % 10}");
    System.Console.WriteLine();
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}
