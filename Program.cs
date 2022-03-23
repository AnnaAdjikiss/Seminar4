// Задача 1
// Написать программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
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