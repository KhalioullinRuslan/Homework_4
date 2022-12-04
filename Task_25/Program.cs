// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumbersAB(string degree)
{
    Console.Write(degree);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = NumbersAB("Введите число А: ");
int numberB = NumbersAB("Введите число В: ");

double exp = Math.Pow(numberA, numberB);
Console.WriteLine($"Степень числа {numberA} в {numberB} = {Math.Round(exp, 2)}");
