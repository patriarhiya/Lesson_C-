Console.Clear();
Console.Write("Введите число, чтобы вывести от -число до число: ");
int N = int.Parse(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}

Console.Clear();
Console.Write("Введите число, чтобы вывести от -число до число: ");
int N = int.Parse(Console.ReadLine());
int B = -N;
while(B <= N)
{
    Console.Write($"{B} ");
}