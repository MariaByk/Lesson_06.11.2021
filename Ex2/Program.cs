// 2. Даны два числа. Показать большее и меньшее число

void MaxMin(int a, int b)
{
    if (a>b)
    {
        Console.WriteLine($"Большее число - {a}, меньшее число - {b}.");
    }
    else 
    Console.WriteLine($"Большее число - {b}, меньшее число - {a}.");
}

MaxMin(10,7);