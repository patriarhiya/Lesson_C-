Console.Clear();
Console.Write("Введите число, чтобы вывести от -число до число: ");
int N = int.Parse(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine($"Вариант 2");
int B = -N;
while(B <= N)
{
    Console.Write($"{B} ");
    B++;
}