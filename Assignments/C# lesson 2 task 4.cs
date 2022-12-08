char noqte = '.';

char vergul = ',';

string metn;

Console.WriteLine("Mətn daxil edin");

metn = Console.ReadLine();

if (metn.Contains(','))
{
    vergul = noqte;

    Console.WriteLine(vergul);
}

else
{
    Console.WriteLine("Daxil edilmiş mətndə ',' yoxdur");
}