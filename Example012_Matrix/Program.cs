string[,] table = new string[2, 5];
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"{rows+1} {columns+1}:{table[rows, columns]}");
    }    
}

int[,] matrix = new int[3, 4];
