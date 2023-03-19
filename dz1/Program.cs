// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

try
{
    Console.WriteLine("Введите число A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    uint B = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine($"A в степени B равно {ExponentCalc(A, B)}");
}
catch
{
    Console.WriteLine("Введены неверные данные");
}




int ExponentCalc(int A, uint B)
{
    int result = 1;
    for (int i = 1; i<=B; i++)
    {
        result = result * A;
    }
return result;
}
