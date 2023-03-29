//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число: ");
int N=int.Parse(Console.ReadLine());
int i=10;
if(N>i*10)
{
    while(N/i<100)
    {
        System.Console.WriteLine(N%i);
    }
        i=i*10;   
}
else
{
    System.Console.WriteLine("третьей цифры нет");
    }