Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if (n1>n2)
    Console.WriteLine($"max = {n1}, min = {n2}");
else
    Console.WriteLine($"max = {n2}, min = {n1}");
    