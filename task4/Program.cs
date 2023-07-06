// Напишите програму, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7, -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());
int max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;
    Console.WriteLine($"max = {max}");
