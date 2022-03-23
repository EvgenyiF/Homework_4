// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число А: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int b = 0;
int summ =0;
while (a!=0)
{
b = a%10;
a/=10;
summ = summ+b;
}
Console.Write($"Сумма цифр в числе равна {summ}");