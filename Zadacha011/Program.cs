// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
string a = Console.ReadLine()!;

if (a.Length > 2)
{
    Console.WriteLine($"Третья цифра: {a[2]}");
}
else 
{
    Console.WriteLine("Третьей цифры нет!");
}

