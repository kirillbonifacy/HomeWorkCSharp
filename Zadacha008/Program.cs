// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10, 100);
int max = 0;

int maxDigit()
{
    int DigitOne = a / 10;
    int DigitTwo = a % 10;
    if (DigitOne > DigitTwo) max = DigitOne;
    else max = DigitTwo;

    return max;
}

maxDigit();

Console.WriteLine($"В числе {a} наибольшая цифра {max}");
