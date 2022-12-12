Gun();
static void Gun()
{
    Console.WriteLine("1. Gulleni tek tek at");
    Console.WriteLine("2. Gullenin hamisini birden at");
    Console.WriteLine("3. Mermini yeniden doldur");
    Console.WriteLine("4. Oyundan chix");
    Console.WriteLine("5. Mermi sayini goster");

    int input = int.Parse(Console.ReadLine());
    int bullet = 30;

    while (input < 6 && input > 0)
    {
        while (input < 1 && input > 5)
        {
            Console.WriteLine("Duzgun reqem daxil edin");
            input = int.Parse(Console.ReadLine());
        }

        while (input == 1 && bullet > 0)
        {
            Console.WriteLine($"Qalan gulle sayi: {bullet -= 1}");
            input = int.Parse(Console.ReadLine());
        }

        while (input == 2 && bullet > 0)
        {
            Console.WriteLine($"Gulleler atildi: {bullet = 0}");
            input = int.Parse(Console.ReadLine());
        }

        while (input == 3)
        {
            Console.WriteLine($"Gulleler dolduruldu: {bullet = 30}");
            input = int.Parse(Console.ReadLine());
        }

        while (input == 4)
        {
            Console.WriteLine("Oyundan cixildi");
            return;
        }

        while (input == 5)
        {
            Console.WriteLine($"Qalan merminiz: {bullet}");
            input = int.Parse(Console.ReadLine());
        }
    }
}