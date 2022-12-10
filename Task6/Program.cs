Console.Clear();
Console.Write("Введите число, чтобы узнать чётное ли оно: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
    Console.Write("Да, число чётное");
else
    Console.Write("Нет, число нечётное");