//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("введите трехзначное число");
int N=int.Parse(Console.ReadLine());
int K=N/10;
System.Console.WriteLine(K%10);