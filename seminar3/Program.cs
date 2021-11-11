/*
Почувствуй себя интерном
0. Вывести квадрат числа
1. По двум заданным числам проверять является ли первое квадратом второго
2. Даны два числа. Показать большее и меньшее число
3. По заданному номеру дня недели вывести его название
4. Найти максимальное из трех чисел
5. Написать программу вычисления значения функции y=f(a)
6. Выяснить является ли число чётным
7. Показать числа от -N до N
8. Показать четные числа от 1 до N
9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа
11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет
*/
Console.WriteLine("Введите номер задачи от 0 до 14-ти ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number) 
{
    case 0: 
Console.WriteLine("Задача №0 ");

Console.WriteLine("Введите число, чтобы узнать его квадрат :");

int c = Convert.ToInt32(Console.ReadLine());

int kvadr = c * c;
Console.WriteLine($"Квадрат заданного числа : {kvadr}");
    break;
    case 1:
Console.WriteLine("Задача №1 ");

Console.WriteLine("Введите два числа, чтобы узнать является ли первое квадратом второго :");

int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

int xx = second * second;
if (first == xx)
{
    Console.WriteLine($"Число {first} является квадратом числа {second}");
}
else 
{
    Console.WriteLine($"Число {first} не является квадратом числа {second}");
}
    break;
    case 2:
Console.WriteLine("Задача №2 ");

Console.WriteLine("Введите два числа для сравнения их величины");

int first2 = Convert.ToInt32(Console.ReadLine());
int second2 = Convert.ToInt32(Console.ReadLine());

if (first2>second2)
{
    Console.WriteLine($"Число {first2} - наибольшее, число {second2} - наименьшее ");
}
else 
{
    Console.WriteLine($"Число {second2} - наибольшее, число {first2} - наименьшее ");
}
    break;
    case 3:
Console.WriteLine("Задача №3 ");

Console.WriteLine("Введите число от 1 до 7-ми, чтобы получить соответствующий день недели");

int dayoftheweek = Convert.ToInt32(Console.ReadLine());
int i = 0;
   /* while (i == 0)
    {
        if ((dayoftheweek <= 0 && dayoftheweek >= 8) && (dayoftheweek2 <= 0 && dayoftheweek2 >= 8))
        {
            Console.WriteLine("Введите число от 1 до 7-ми, чтобы получить соответствующий день недели");
            NewMethod1();
        }
        else
        {
            i++;
            int dayoftheweek2 = dayoftheweek;
        }
    } */
switch (dayoftheweek)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;

    case 2:
    Console.WriteLine("Вторник");
    break;

    case 3:
    Console.WriteLine("Среда");
    break;

    case 4:
    Console.WriteLine("Четверг");
    break;

    case 5:
    Console.WriteLine("Пятница");
    break;

    case 6:
    Console.WriteLine("Суббота");
    break;

    case 7:
    Console.WriteLine("Воскресенье");
    break;

    default:
    Console.WriteLine("Вы ввели число, не удовлетворяющее требованиям программы ");
    break;
}

/*static void NewMethod()
{
    var dayoftheweek2 = Convert.ToInt32(Console.ReadLine());
}*/
    break;
    case 4:
Console.WriteLine("Задача №4 ");

Console.WriteLine("Введите три числа для нахождения среди них максимального ");

int one = Convert.ToInt32(Console.ReadLine());
int two = Convert.ToInt32(Console.ReadLine());
int three = Convert.ToInt32(Console.ReadLine());

if (one>two)
{
    if (one>three)
    {
        Console.WriteLine($"Максимальное из трёх - {one}");
    }
    else
    {
        Console.WriteLine($"Максимальное из трёх - {three}");
    }
}
else
{
    if (two>three)
    {
        Console.WriteLine($"Максимальное из трёх - {two}");
    }
    else 
    {
        Console.WriteLine($"Максимальное из трёх - {three}");
    }
}
    break;
    case 5:
    
    break;
    case 6:
Console.WriteLine("Задание №6 ");
Console.WriteLine("Введите число для его проверки на чётность ");

int chet = Convert.ToInt32(Console.ReadLine());

if (chet%2 == 0)
{
    Console.WriteLine($"Число {chet} - чётное ");
}
else 
{
    Console.WriteLine($"Число {chet} - нечётное ");
}
    break;
    case 7:
Console.WriteLine("Задание №7 ");
Console.WriteLine("Введите n чтобы увидеть числа от -n до n ");

int n = -1-(Convert.ToInt32(Console.ReadLine()));
int f = -2*n -1;
 
for (int v = 0; v < f; Console.WriteLine($"n = {n}"))
{
    v++;
    n++;
}
    break;
}