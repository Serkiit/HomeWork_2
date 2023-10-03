// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели:");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
    }
}