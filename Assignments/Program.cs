using Mini_consol_app;
using Mini_consol_app.Services.Implementations;
using Mini_consol_app.Services.Interfaces;

StudentService student1 = new();

Console.WriteLine("1. Yeni telebe yarat \n2. Telebe sil \n3. Redakte et \n4. Butun melumatlar \n5. Telebe tap\n0. Cixis");

string input = Console.ReadLine();

while (input!="0")
{
    switch (input)
    {
        case "1":
            Console.Write("Telebenin ad, soyad ve ortalamasini daxil edin: ");
            int input1 = int.Parse(Console.ReadLine());
            student1.Create("Samir", "Orucov", 71.5);
            break;

        case "2":
            Console.WriteLine("Silmek istediyiniz telebenin ID`ni daxil edin: ");
            int input2 = int.Parse(Console.ReadLine());
            student1.Delete(1);
            break;

        case "3":
            Console.WriteLine("Melumatlarini deyismek istediyiniz telebenin ID`ni daxil edin: ");
            int input3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yeni ad ve soyadi daxil edin: ");
            student1.Edit(1, "Samir", "Orucov");
            break;

        case "4":
            Console.WriteLine("Qrupdaki telebeler:\n");
            student1.GetAll();
            break;

        case "5":
            Console.WriteLine("Telebe ID daxil edin: ");
            int input4 = int.Parse(Console.ReadLine());
            student1.GetById(1);
            break;

        case "0":
            input = "0";
            Console.WriteLine("Cixis edildi");
            break;

        default:
            Console.WriteLine("Emeliyyat yalnisdir");
            break;
    }
}
