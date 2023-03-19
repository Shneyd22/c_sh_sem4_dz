// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

try
{
    Console.WriteLine("Введите число");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма всех цифр числа равна {NumSum(A)}");
}
catch
{
    Console.WriteLine("Введены некорректные данные");
}




int NumSum(int A)
{
    int remain = 1;
    int num = 1;
    int digit = 1;
    int sum = 0;
    while (num != 0)
    {
        remain = (A / digit) % 10;
        sum = sum + remain;
        num = A / digit;
        digit = digit * 10;
    }
return sum;
}