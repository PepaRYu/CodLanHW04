int [] GetBinaryArray(int size)
{
    int [] result = new int[size];
    // result.Length = size
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(10);
    }
    return result;

}

int [] array = GetBinaryArray(8);
Console.Write($"[{String.Join(",", array)}]");