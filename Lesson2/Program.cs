Console.Clear();
Console.Write("Введите день недели: ");
int a = int.Parse(Console.ReadLine());
if(a == 1){Console.WriteLine($"{a} день недели это понедельник");}
else if(a == 2){Console.WriteLine($"{a} день недели это вторник");}
else if(a == 3){Console.WriteLine($"{a} день недели это среда");}
else if(a == 4){Console.WriteLine($"{a} день недели это четверг");}
else if(a == 5){Console.WriteLine($"{a} день недели это пятница");}
else if(a == 6){Console.WriteLine($"{a} день недели это суббота");}
else if(a == 7){Console.WriteLine($"{a} день недели это воскресенье");}
else {Console.WriteLine($"{a} день не существует");}
