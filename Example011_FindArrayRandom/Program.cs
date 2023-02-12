void FillArray(int[] collection)
{
     int lenght = collection.Length;
     int i = 0;
     while(i < lenght){
        collection[i] = new Random().Next(1, 100);
        i++;
     }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count ){
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
