Console.Clear();
Console.Write("Введите число, чтобы узнать список чётных чисел между ним и цифрой 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i < n; i++)
    if (i % 2 == 0)
    Console.Write($"{i} ");