// Выяснить, кратно ли число заданному, если нет, вывести остаток.


Console.Write("Введите число: ");
int a = int.Parse (Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse (Console.ReadLine()!);

// int a = new Random().Next(11, 101);
// int b = new Random().Next(1, 11);

int result = 0;

int MultipleNumber()
{
    result = a % b;
    return result;
}

MultipleNumber();

if (result == 0) Console.WriteLine($"Число {a} кратно числу {b}");
else
{
    Console.WriteLine($"Число {a} не кратно числу {b}, остаток от деления равен {a % b}");
}