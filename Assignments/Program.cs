using Access_modifiers;

Product product1 = new Product("sud", 2, 50);

int stock = product1.Count;

int income = product1.TotalIncome;

int price = product1.price;

while (stock>0)
{
    Console.Write("Mehsuldan nece eded satmaq istediyinizi daxil edin: ");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input<=stock)
    {
        stock -= input;
        income = input * price;
        Console.WriteLine($"Mehsuldan {input} eded satildi. Umumi gelir: {income} azn Qalan: {stock} eded");
    }
    else
    {
        Console.WriteLine($"Istediyiniz sayda mehsul qalmayib. Qalan: {stock}");
    }
}
