static int AvgCalc(int[] array)
{
    int avg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        avg = avg + array[i];
    }
    avg /= array.Length;
    return avg;
}

static int MaxVal(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}