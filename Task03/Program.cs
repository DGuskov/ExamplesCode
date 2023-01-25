// написать программу, котрая будет выдавать 
// название дня недели по заданному номеру. 
// например:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("это Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Это Вторник");
}
if (number == 3)
{
    Console.WriteLine("Это Среда");
}
if (number == 4)
{
    Console.WriteLine("это Четверг");
}
if (number == 5)
{
    Console.WriteLine("Это Пятница");
}
if (number == 6)
{
    Console.WriteLine("Это Суббота");
}
if (number == 7)
{
    Console.WriteLine("Это Воскресенье");
}
