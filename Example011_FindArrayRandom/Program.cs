void FillArray(int[] collection)
{
    for(int i = 0;i < collection.Length;i++) collection[i] = new Random().Next(1, 10);
}

void PrintArray(int[] collection)
{
    for(int i = 0;i < collection.Length;i++) Console.WriteLine(collection[i]);
}

int IndexOf(int[] collection, int find)
{
    int position = 0;
    for (int i = 0;i < collection.Length;i++)
        if(collection[i] == find)
        {
            position = i;
            break;
        }
        return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int position = IndexOf(array, 3);
Console.WriteLine(position);
