// Напишите программу, которая принимает на вход три числа и выдает
// максимальное значение из этих чисел. 
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > 0)
{
    MaxNumber = number1;    
    Console.WriteLine("Максимальное число = " + MaxNumber);
}
else if (number2 > MaxNumber)
{
    MaxNumber = number2;
    Console.WriteLine("максимальное число = " + MaxNumber);
}
else if (number3 > MaxNumber)
{
    MaxNumber = number3;
    Console.WriteLine("Максимально число = " + MaxNumber);
}
else
{
    Console.WriteLine("введены некорректные значения");
}
