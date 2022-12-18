using C_task_class;

Student student1 = new Student();

student1.Create("Samir", "Orucov", 328, 80, true);

Console.WriteLine("Istediyiniz emeliyyati secin: ");
Operations();

bool control = true;

while (control)
{
    string choise = (Console.ReadLine());
    switch (choise)
    {
        case "1":
            student1.NameAndSurname();
            break;
        case "2":
            student1.AllValues();
            break;
        case "3":
            student1.Exam();
            break;
        case "4":
            control = false;
            break;
    }
}

static void Operations()
{
    Console.WriteLine("1. Telebenin ad ve soyadini goster");
    Console.WriteLine("2. Telebenin butun melumatlarini goster");
    Console.WriteLine("3. Novbeti imtahan sansi");
    Console.WriteLine("4. Cixis");
}
