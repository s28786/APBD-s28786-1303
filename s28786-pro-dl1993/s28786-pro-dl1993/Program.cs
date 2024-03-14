static int AvgCalc(int[] array)
{
    int avgNew = 0;
    for (int i = 0; i < array.Length; i++)
    {
        avgNew += array[i];
    }
    avgNew /= array.Length;
    return avgNew;
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