Console.WriteLine("Yaşınızı daxil edin.");

int yash;

int il;

yash = Convert.ToInt32(Console.ReadLine());

if (yash >= 18)
{
    Console.WriteLine("Sürücülük vəsiqəsi ala bilərsiniz");
}

else
{
    il = 18 - yash;
    Console.WriteLine(il + " ildən sonra sürücülük vəsiqəsi ala bilərsiniz");
}