//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет



//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа


void Number3(int a)
    {
        int a1 = a % 10;
        Console.WriteLine("Единицы: " + a1);
        int a10 = (a % 100 - a % 10) / 10;
        Console.WriteLine("Десятки: " + a10);
        int a100 = a / 100;
        Console.WriteLine("Сотни: " + a100);

    }
// Number3(987);


// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

void NumberMax(int number)
{
    Console.WriteLine("Число: " + number);
    int a = number % 10;
    int b = (number % 100 - number % 10) / 10;
    int max = b;
    if (a>b) max = a;
    Console.WriteLine("Наибольшая цифра числа: " + max);
}

// int num = new Random().Next(10, 100);
// NumberMax(num);


// 12. Удалить вторую цифру трёхзначного числа

void NumberDelete(int a)
    {
        int a1 = a % 10;
        Console.WriteLine("Единицы: " + a1);
        int a10 = (a % 100 - a % 10) / 10;
        Console.WriteLine("Десятки: " + a10);
        int a100 = a / 100;
        Console.WriteLine("Сотни: " + a100);
        int b = a100*10 + a1;
        Console.WriteLine("Новое число: " + b);
    }

// NumberDelete(159);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

void Div(int a, int b)
{
    if (a % b == 0) Console.WriteLine($"{a} делится на {b} без остатка!");
    else Console.WriteLine(a%b);

}

// Div(20, 10);

// 14. Найти третью цифру числа или сообщить, что её нет

void Number(int a)
    {
        if(a > 99)
        {
        Console.WriteLine((a / 100) % 10);
        }
        else Console.WriteLine("В числе менее 3-х цифр");
    }
  
Number(12);
