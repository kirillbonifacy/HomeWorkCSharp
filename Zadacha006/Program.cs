// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
string a = Console.ReadLine()!;

if (a.Length != 3)    // Проверка на трёхзначность!
{
    Console.WriteLine("Число не трёхзначное!");
    
}
else
{
    Console.WriteLine($"Третье число: {a[2]}");
} 
