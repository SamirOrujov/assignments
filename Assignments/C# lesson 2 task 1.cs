int number;

Console.WriteLine("Ədəd daxil edin.");

number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number / 2);
    }
    
    else if (number % 2 != 0)
    {
        Console.WriteLine(number * 2);
    }
}

else
{
    Console.WriteLine("Natural ədəd daxil olunmalıdır.");
}