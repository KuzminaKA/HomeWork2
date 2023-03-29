//адача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
System.Console.WriteLine("введите цифру дня недели");
int i=int.Parse(Console.ReadLine());

bool Weekday (int a,int b)
{
    return a<=b;
}

if (Weekday(i,5))
{
    System.Console.WriteLine("нет");
}
else
{
    System.Console.WriteLine("ДА!");
}
