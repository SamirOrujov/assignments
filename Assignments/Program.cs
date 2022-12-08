int saygac = 0;

{
    int[] coxluq = new int[100];

    for (int i = 0; i < 100; i++)
    {
        coxluq[i] = i + 1;
    }

    foreach (int eded in coxluq)
    {
        if (eded % 5 == 0)
        {
            saygac++;
        }

    }
}

Console.WriteLine(saygac);