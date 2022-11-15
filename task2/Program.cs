// Заоплнить массив случайным образом и найти нужный индекс

void FillArray(int[] namearray)

{
    int length = namearray.Length;
    int index = 0;
    while (index < length)
    {
        namearray[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] araprint)

{
    int size = araprint.Length;
    int position = 0;
    while(position < size)
    {
        Console.Write($" {araprint[position]}");
        position++;
    }
}

int IndexFindDig(int[] araend, int find)
{
    int count = araend.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(araend[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexFindDig(array, 44);
Console.WriteLine(pos);
