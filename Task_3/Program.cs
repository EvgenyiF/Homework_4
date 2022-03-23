// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
}
Console.Write("Массив заполненый рандомно числами от 0 до 999: ");
Console.WriteLine("[{0}]", string.Join(", ", array));