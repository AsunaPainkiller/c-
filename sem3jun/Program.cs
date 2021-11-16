/*Почувствуй себя джуном
15. Дано число. Проверить кратно ли оно 7 и 23
16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Задать номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D*/

Console.WriteLine("Введите номер задачи от 15-ти до 22-х ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number) 
{
    case 15:
Console.WriteLine("Задание №15 ");
Console.WriteLine("Введите число, чтобы узнать кратно ли оно 7 и 23 ");

int crat = Convert.ToInt32(Console.ReadLine());

if ((crat%7 == 0)&&(crat%23 == 0))
{
    Console.WriteLine($"Число {crat} кратно 7-ми и 23-м ");
}
else
{
    Console.WriteLine($"Число {crat} не кратно 7-ми и 23-м ");
}
    break;
    case 16:
Console.WriteLine("Задание №16 ");
Console.WriteLine("Введите число от 1 до 7-ми, обозначающее день недели, чтобы узнать, является ли он выходным днём ");

int day = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i == 0)
{
switch (day)
{
    case 1:
    Console.WriteLine("Понедельник - рабочий день");
    i++;
    break;

    case 2:
    Console.WriteLine("Вторник - рабочий день");
     i++;
    break;

    case 3:
    Console.WriteLine("Среда - рабочий день");
     i++;
    break;

    case 4:
    Console.WriteLine("Четверг - рабочий день");
     i++;
    break;

    case 5:
    Console.WriteLine("Пятница - рабочий день");
     i++;
    break;

    case 6:
    Console.WriteLine("Суббота - выходной день!");
     i++;
    break;

    case 7:
    Console.WriteLine("Воскресенье - выходной день!");
     i++;
    break;

    default:
    Console.WriteLine("Вы ввели число, не удовлетворяющее требованиям программы, попробуйте снова ");
    Console.WriteLine("Введите число от 1 до 7-ми, чтобы получить соответствующий день недели");
    int day2 = Convert.ToInt32(Console.ReadLine());
    day = day2;
    break;
}
}
    break;
    case 17:
Console.WriteLine("Задание №17 ");
Console.WriteLine("Введите два числа, чтобы узнать является ли одно квадратом другого или же наоборот :");

int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

int xx = second * second;
int yy = first * first;
if (first == xx)
{
    Console.WriteLine($"Число {first} является квадратом числа {second}");
}
else 
{
    Console.WriteLine($"Число {first} не является квадратом числа {second}");
}
if (second == yy)
{
    Console.WriteLine($"Число {second} является квадратом числа {first}");
}
else 
{
    Console.WriteLine($"Число {second} не является квадратом числа {first}");
}
    break;
    case 18:
Console.WriteLine("Задание №18 ");

    break;
    case 19:
//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Задание №19 ");
Console.WriteLine("Введите x и y (причем X ≠ 0 и Y ≠ 0) чтобы узнать номер четверти плоскости данной точки ");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if ((x>0)&&(y>0))
{
    Console.WriteLine($"Точка {x};{y} принадлежит первой четверти координатной плоскости ");
}
if ((x<0)&&(y>0))
{
    Console.WriteLine($"Точка {x};{y} принадлежит второй четверти координатной плоскости ");
}
if ((x<0)&&(y<0))
{
    Console.WriteLine($"Точка {x};{y} принадлежит третьей четверти координатной плоскости ");
}
if ((x>0)&&(y<0))
{
    Console.WriteLine($"Точка {x};{y} принадлежит четвёртой четверти координатной плоскости ");
}
    break;
    case 20:
//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задание №20 ");
Console.WriteLine("Введите номер четверти от 1-го до 4-х, чтобы узнать диапазоны для возможных координат ");

int ch4 = Convert.ToInt32(Console.ReadLine());
int f = 0;
while (f == 0)
{
    switch (ch4)
    {
        case 1:
        Console.WriteLine("Вы выбрали первую четверть. Диапазон - x принадлежит (0; +бесконечность), y принадлежит (0; +бесконечность) ");
        f++;
        break;
        case 2:
        Console.WriteLine("Вы выбрали вторую четверть. Диапазон - x принадлежит (0; -бесконечность), y принадлежит (0; +бесконечность) ");
        f++;
        break;
        case 3:
        Console.WriteLine("Вы выбрали третью четверть. Диапазон - x принадлежит (0; -бесконечность), y принадлежит (0; -бесконечность) ");
        f++;
        break;
        case 4:
        Console.WriteLine("Вы выбрали четвёртую четверть. Диапазон - x принадлежит (0; +бесконечность), y принадлежит (0; -бесконечность) ");
        f++;
        break;
        default:
        Console.WriteLine("Вы ввели число, не удовлетворяющее требованиям программы, попробуйте снова ");
        Console.WriteLine("Введите номер четверти от 1-го до 4-х, чтобы узнать диапазоны для возможных координат ");
        int ch5 = Convert.ToInt32(Console.ReadLine());
        ch4 = ch5;
    break;
    }
}
    break;
    case 21:
//Программа проверяет пятизначное число на палиндром.
Console.WriteLine("Задание №21 ");
Console.WriteLine("Введите пятизначное число, чтобы узнать является ли оно палиндромом ");

int pal = Convert.ToInt32(Console.ReadLine());
int n = 0;
while (n == 0)
{
    if ((pal>9999)&&(pal<100000))
    {
        string sravn = Convert.ToString(pal);
        if((sravn[0] == sravn[4])&&(sravn[1] == sravn[3]))
        {
            Console.WriteLine($"Число {pal} - палиндром! ");
        }
        else
        {
            Console.WriteLine($"Число {pal} - не яляется палиндромом ");
        }
        n++;
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число, либо оно отрицательное. Попробуйте снова :");
        int pal2 = Convert.ToInt32(Console.ReadLine());
        pal = pal2;
    }
}
    break;
    case 22:
    //Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Задание №22 ");
Console.WriteLine("Введите три пары координат, чтобы узнать расстояние между заданными точками в 3D пространстве ");
Console.WriteLine("Первая точка ");
Console.Write("x = ");
int x1 = Convert.ToInt32(Console.ReadLine());
    break;
}