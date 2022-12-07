int qiymet;

Console.WriteLine("Qiyməti daxil edin");

qiymet = int.Parse(Console.ReadLine());

if (qiymet >= 0 && qiymet <= 100)
{
    if (qiymet > 90)
    {
        Console.WriteLine("A aldınız");
    }

    else if (qiymet > 80)
    {
        Console.WriteLine("B aldınız");
    }

    else if (qiymet > 70)
    {
        Console.WriteLine("C aldınız");
    }

    else if (qiymet > 60)
    {
        Console.WriteLine("D aldınız");
    }

    else if (qiymet > 50)
    {
        Console.WriteLine("E aldınız");
    }

    else
    {
        Console.WriteLine("Kəsildiniz");
    }
}

else
{
    Console.WriteLine("0 və 100 aralığında qiymət daxil edin");
}