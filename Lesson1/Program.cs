Console.Clear();
Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int sqr = number1 * number1;
Console.WriteLine($"{sqr == number2}");
if(sqr == number2){Console.WriteLine($"Квадрат числа 1 ({number1}) равно числу номер 2({number2})");}
else{Console.WriteLine($"Квадрат числа 1 ({number1}) не равно числу номер 2 ({number2})");}

int sqr1 = Convert.ToInt32(Math.Pow(number1, 2));
Console.WriteLine($"Квадрат числа {number1} -> {sqr1}");