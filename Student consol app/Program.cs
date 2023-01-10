using Student_consol_app.Services.Implementations;

StudentS studentService = new StudentS();
studentService.Create("Samir", "Orucov", 90);
studentService.Create("Rza", "Mirzeyev", 85);
studentService.Create("Elsad", "Memmedov", 75);
studentService.Edit(3, Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));