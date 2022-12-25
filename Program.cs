using Calculator;
using System.Net.Http.Headers;

Calculate generalInput = new();

Console.Write("1ci ededi daxil ediniz: ");

generalInput.input1 = int.Parse(Console.ReadLine());

Console.Write("Emeliyyat isaresini daxil ediniz: ");

generalInput.input2 = (Console.ReadLine());

bool check = string.IsNullOrWhiteSpace(generalInput.input2); 

Console.Write("2ci ededi daxil ediniz: ");

generalInput.input3 = int.Parse(Console.ReadLine());

if (generalInput.input2 == "+")
{
    var sum = generalInput.Sum();
    Console.WriteLine($"Daxil etdiyiniz ededlerin cemi: {sum}");
}
else if (generalInput.input2 == "-")
{
    var extract = generalInput.Extract();
    Console.WriteLine($"Daxil etdiyiniz ededlerin ferqi: {extract}");
}
else if (generalInput.input2 == "*")
{
    var multiply = generalInput.Multiply();
    Console.WriteLine($"Daxil etdiyiniz ededlerin hasili: {multiply}");
}
else if (generalInput.input2 == "/")
{
    var divide = generalInput.Divide();
    Console.WriteLine($"Daxil etdiyiniz ededlerin nisbeti: {divide}");
}
else
{
    Console.WriteLine("Dogru emeliyyat isaresi daxil ediniz");
}

