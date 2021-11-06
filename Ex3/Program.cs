//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет


//  3. По заданному номеру дня недели вывести его название

void DayOfWeek(int a)
{
    if (a == 1) Console.WriteLine("Понедельник");
    if (a == 2) Console.WriteLine("Вторник");
    if (a == 3) Console.WriteLine("Среда");
    if (a == 4) Console.WriteLine("Четверг");
    if (a == 5) Console.WriteLine("Пятница");
    if (a == 6) Console.WriteLine("Суббота");
    if (a == 7) Console.WriteLine("Воскресенье");
}
// Console.Write("День недели - ");
// DayOfWeek(6);

//  4. Найти максимальное из трех чисел

int MaxNumber(int a, int b, int c)
{
int max = 0;
    if (a>b && a>c) max = a;
    if (b>a && b>c) max = b;
    if (c>b && c>a) max = c;
return max;
}

// int res = MaxNumber(4, 2, 3);
// Console.Write("Максимальное из 3-х чисел - ");
// Console.WriteLine(res);

//  5. Написать программу вычисления значения функции y=f(a)

int Function(int a)
{
    a = a*a;
    return a;
}
// int res = Function(2);
// Console.Write("Значение функции y=f(a) - ");
// Console.WriteLine(res);

//  6. Выяснить является ли число чётным

bool EvenNumber(int a)
{
    if (a%2 == 0) return true;
    else return false;
}
// bool res = EvenNumber(6);
// Console.Write($"Число четное - ");
// Console.WriteLine(res);



// М   А   С   С   И   В   Ы
///////////////////////////////////////////////////////////////////
//  7. Показать числа от -N до N

// void FillArray(int[] collection, int k)
// {
//     k = -k;
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
        
//         collection[index] = k; 
//         k = k+1;      
//         index++;
//     }

// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// int n = 10; // переменная n
// int[] array = new int[n*2+1];
// FillArray(array,n);

// PrintArray(array);


//  8. Показать четные числа от 1 до N

void FillArray(int[] collection, int k)
{
    int length = collection.Length;
    int index = 0;
        while (index < length)
    {
        k = k-1;
        collection[index] = length - k;     
        index++;
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if(col[position]%2==0)
        {
        Console.WriteLine(col[position]);
        }
        position++;
    }
}
int n = 17; // переменная n
int[] array = new int[n];
FillArray(array,n);

PrintArray(array);