﻿Console.Clear();
int num = new Random().Next(100,1000);
int a1 = num / 100;
int a2 = num % 10;
int result = a1*10 + a2;
Console.WriteLine($"Для числа {num} ответ: {result}"); 
