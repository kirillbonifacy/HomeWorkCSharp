// Удалить вторую цифру трёхзначного числа

int a = new Random().Next(100, 1000);
int b = 0;

int NumberWithoutSecDig()
{
    b = a / 100 * 10 + a % 10;
    return b;
}

NumberWithoutSecDig();


Console.WriteLine($"Если из числа {a} удалить вторую цифру, получится число {b}");
