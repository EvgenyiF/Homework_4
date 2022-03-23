// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double Degree(int a, int b)
{
    double res = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        res = res * a;
    }
    return res;
}
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
double res = 0;
if (b >= 0)
{
    res = Degree(a, b);
}
else
{
    res = Degree(a, b);
    res = 1 / res;
}
Console.Write($"Число {a} в степени {b} = {res}");