// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N.
// 5 -> 2, 4
//8 -> 2, 4, 6, 8

int StartNum = 1;
Console.WriteLine("Введите натуральное число:");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num > 0)
{
    int count = Num;
    while (count % 2 == 0)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("число должно быть больше одного");
}
