// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
double a = double.Parse(Console.ReadLine()!);

if (n.Length != 3)    // Проверка на трёхзначность!
{
    System.Console.WriteLine($"Последняя цифра числа {a} это {a % 10}");
    System.Console.WriteLine();
}
else
{
    Console.WriteLine("Число не трёхзначное!");
} 
