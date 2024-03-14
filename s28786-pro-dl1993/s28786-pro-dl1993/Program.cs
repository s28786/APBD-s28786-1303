static int AvgCalc(int[] array)
{
    int avg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        avg += array[i];
    }
    avg /= array.Length;
    return avg;
}