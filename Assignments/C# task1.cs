int eded;

Console.WriteLine("Ədəd daxil edin");

eded = int.Parse(Console.ReadLine());

if (eded <= 0)
{
    Console.WriteLine("Müsbət ədəd daxil edin");
}

else if (eded % 21 == 0)
{
    Console.WriteLine("Daxil olunan ədəd 3 və 7-ə qalıqsız bölünür.");
}

else
{
    Console.WriteLine("Daxil olunan ədəd 3 və 7-ə qalıqsız bölünmür.");
}