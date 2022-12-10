Console.Clear();
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
    Console.Write($"max={n1}");
else
    Console.Write($"max={n2}");