﻿// Задача 1
// Написать программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
/*
int ArythmSum(int A)
{
    int result = 0;
    if (A >= 1)
    {
        int i = 1;
        while (i <= A)
        {
            result = result + i;
            i++;
        }
    }
    else Console.WriteLine("Вы ввели некорректное число");
    return result;
}
Console.WriteLine("Введите целое положительное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {numA} равна {ArythmSum(numA)}");
*/


//Задача 2
// Программа принимает на вход число и выдает количество цифр в числе
/*
void Digits(int value)
{
    int lenght = 1;
    while (Math.Abs(value / 10) > 1)
    {
        value = value / 10;
        lenght++;
    }
    Console.WriteLine("количество цифр: " + lenght);
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Digits(number);
*/

//Задача 3
// Написать программу, которая принимает на вход число А и выдает произведение чисел от 1 до А
/*
int Product(int value)
{
    int result = 1;
    int i = 1;
    while (i <= value)
    {
        result = result * i;
        i++;
    }
    return result;
}
Console.WriteLine("Введите целое положительное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввел некорректное число");
else Console.WriteLine($"Произведение чисел от 1 до {numA} равно {Product(numA)}");
*/

//Задача 4
//Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1

void arrayNew()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i] + " ");
    }
}
arrayNew();
