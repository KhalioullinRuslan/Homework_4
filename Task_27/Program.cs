// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SomeNumber(string summa)
{
    Console.Write(summa);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Decomposition(int number)
{
    int sum;
    for (sum = 0; number != 0; number = number/10)
    {
        int count = number % 10;
        sum = sum + count;
        // Console.WriteLine(sum); 
    }
    return sum;
}
int num = SomeNumber("Введите число: ");
if (num > 0)
{
    int sum = Decomposition(num);
    Console.WriteLine(sum);
}
else 
    Console.WriteLine("Введено неверно число");