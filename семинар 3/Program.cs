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
while (i == 0)
{
switch (dayoftheweek)
{
    case 1:
    Console.WriteLine("Понедельник");
    i++;
    break;

    case 2:
    Console.WriteLine("Вторник");
     i++;
    break;

    case 3:
    Console.WriteLine("Среда");
     i++;
    break;

    case 4:
    Console.WriteLine("Четверг");
     i++;
    break;

    case 5:
    Console.WriteLine("Пятница");
     i++;
    break;

    case 6:
    Console.WriteLine("Суббота");
     i++;
    break;

    case 7:
    Console.WriteLine("Воскресенье");
     i++;
    break;

    default:
    Console.WriteLine("Вы ввели число, не удовлетворяющее требованиям программы, попробуйте снова ");
    Console.WriteLine("Введите число от 1 до 7-ми, чтобы получить соответствующий день недели");
    int dayoftheweek2 = Convert.ToInt32(Console.ReadLine());
    dayoftheweek = dayoftheweek2;
    break;
}
}
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
Console.WriteLine("Задание №5 ");
Console.WriteLine("Введите значение, чтобы узнать как с ним изменится функция y=5x+3 ");

int znach = Convert.ToInt32(Console.ReadLine());
int funk =5*znach+3;

Console.WriteLine($"Функция равняется {funk} ");
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
    case 8:
Console.WriteLine("Задание №8 ");
Console.WriteLine("Введите n чтобы увидеть числа от 1 до n ");

int h = Convert.ToInt32(Console.ReadLine());

for (int g = 0; g < h; Console.WriteLine($"n = {g}"))
{
    g++;
}
    break;
    case 9:
Console.WriteLine("Задание №9 ");
Console.WriteLine("Введите трёхзначное число чтобы узнать его третью цифру ");

string third =Console.ReadLine();
int th = Convert.ToInt32(third);
if (th>99)
{
    Console.WriteLine($"Третья цифра числа - {third[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры у числа нет, либо оно отрицательное и проверено ниже ");
}
if (th<(-99))
{
    Console.WriteLine($"Третья цифра числа - {third[3]}");
}
else
{
    Console.WriteLine($"Третьей цифры у числа однозначно нет ");
}
    break;
    case 10:
Console.WriteLine("Задание №10 ");
Console.WriteLine("Введите трёхзначное число чтобы узнать его вторую цифру ");

string sec =Console.ReadLine();
int sc = Convert.ToInt32(sec);

if (sc>99)
{
    Console.WriteLine($"Вторая цифра числа - {sec[1]}");
}
else
{
    Console.WriteLine($"Вторая цифры у числа нет, либо оно отрицательное и проверено ниже ");
}
if (sc<(-99))
{
    Console.WriteLine($"Вторая цифра числа - {sec[2]}");
}
else
{
    Console.WriteLine($"Второй цифры у числа однозначно нет ");
}
    break;
    case 11:
Console.WriteLine("Задание №11 ");
Console.WriteLine("Введите число из отрезка [10;99] чтобы узнать наибольшую цифру числа ");

string one11 = Console.ReadLine();
int on11 = Convert.ToInt32(one11);

if (on11>9 && on11<100)
{
    if (one11[0]>one11[1])
    {
        Console.WriteLine($"Наибольшая цифра - {one11[0]}");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра - {one11[1]}");
    }
}
else
{
    Console.WriteLine("Вы ввели число, не соответствующее данному отрезку ");
}

    break;
    case 12:
Console.WriteLine("Задание №12 ");
Console.WriteLine("Введите трёхзначное число чтобы мы удалили его вторую цифру ");

string one12 = Console.ReadLine();
int on12 = Convert.ToInt32(one12);

if (on12>99 && on12<1000)
{
    one12 = String.Concat(one12[0], one12[2]);
    Console.WriteLine($"Результат - {one12} ");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число ");
}

    break;
    case 13:
Console.WriteLine("Задание №13 ");
Console.WriteLine("Введите два числа чтобы узнать кратно ли второе первому, либо получить остаток от деления ");

int crat = Convert.ToInt32(Console.ReadLine());
int crat2 = Convert.ToInt32(Console.ReadLine());

if (crat2%crat == 0)
{
    Console.WriteLine("Второе число кратно первому ");
}
else 
{
    double del = crat2/crat;
    Console.WriteLine($"Остаток числа от деления второго числа на первое равен {del}");
}
    break;
    case 14:
Console.WriteLine("Задание №14 ");
Console.WriteLine("Введите число чтобы узнать его третью цифру ");

string third14 =Console.ReadLine();
int th14 = Convert.ToInt32(third14);
if (th14>0)
{
    Console.WriteLine($"Третья цифра числа - {third14[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры у числа нет, либо оно отрицательное и проверено ниже ");
}
if (th14<(0))
{
    Console.WriteLine($"Третья цифра числа - {third14[3]}");
}
else
{
    Console.WriteLine($"Третьей цифры у числа однозначно нет ");
}
    break;
}
