int[] array = { 2, 4, 6, 7, 44, 33, 1, 22, 345, 33, 33, 111, 11};
int n = array.Length;
Console.WriteLine($"Длина масссива = {n}");
int find = 22;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Искомое число имеет индекс = {index}");
        break;
    }
    index++;
}
