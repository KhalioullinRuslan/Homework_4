// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ArrayNumber(string mass)
{
    Console.Write(mass);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[] charr)
{
    int i;
    for (i = 0; i < charr.Length - 1; i++)
    {
        Console.Write(charr[i] + ", ");
    }
    Console.Write(charr[i]);
}

void RandomIndex(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
}

Console.Clear();
int[] array = new int[8];
RandomIndex(array);
PrintArray(array);