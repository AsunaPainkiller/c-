// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// Задать массив


using System;
using System.Collections;

int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив
Console.WriteLine("Список переменных:");
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
ArrayList objectList1 = new ArrayList() {currentElement};
Console.WriteLine("Список переменных по возрастанию :");
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
        objectList1.Add(array[index]);
    }
    index++;
}
index = 0;
int summ = 0;
for (int i = 0; i < array.Length; i++)
     summ += array[i];
int mid = summ/array.Length;
index = 0;
Console.WriteLine($"Среднее арифметическое = {mid}");
Console.WriteLine("Список переменных, которые меньше среднего арифметического :");
ArrayList objectList2 = new ArrayList() {};
while (index <=9)
{
    if(array[index] < mid)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
        objectList2.Add(array[index]);
    }
    index++;
}
index = 0;
Console.WriteLine("Список нечётных элементов массива :");
ArrayList objectList3 = new ArrayList() {};
while (index <=9)
{
    if (array[index]%2 != 0)
    {
        Console.WriteLine(array[index]);
        objectList3.Add(array[index]);
    }
    index++;
}