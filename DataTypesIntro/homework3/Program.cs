namespace homework3;

internal class Program
{
    //homework1
    //Создать массив из 5 абитуриентов (Candidate), заполнить его 
    //Вывести список всех улиц, на которых живут абитуриенты 

    static void Main(string[] args)
    {
        Candidate candidate1 = new(
            new Person("Aliaksei", "Kazlou",
            new Adress("Zhodino", "Mira", 15, 12)),
            new SubjectScore[]
            {
            new( "Language", 8 ),
            new( "Math", 10 )
            });

        Candidate candidate2 = new(
            new Person("Maksim", "Rubanau",
            new Adress("Minsk", "Aerodromnaya", 1, 22)),
            new SubjectScore[]
            {
            new ("Language", 7),
            new ("Math", 9)
            });

        Candidate candidate3 = new(
            new Person("Alesia", "Zabavskaia",
            new Adress("Minsk", "Matysevicha", 12, 16)),
            new SubjectScore[]
            {
            new ("Language", 6),
            new ("Math", 7)
            });

        Candidate candidate4 = new(
            new Person("Svetlana", "Zenkovich",
            new Adress("Minsk", "Krasivaya", 66, 31)),
            new SubjectScore[]
            {
            new ("Language", 5),
            new ("Math", 9)
            });

        Candidate candidate5 = new(
            new Person("Victor", "Acramchuk",
            new Adress("Minsk", "Pushkina", 18, 44)),
            new SubjectScore[]
            {
            new ("Language", 4),
            new ("Math", 6)
            });

        Candidate[] array =
        {
            candidate1,
            candidate2,
            candidate3,
            candidate4,
            candidate5
        };

        Console.WriteLine(" Streets where students live: ");
        Console.WriteLine(("").PadRight(30, '-'));

        foreach (Candidate candidate in array)
        {
            string street = candidate.Person.Adress.Street;
            Console.WriteLine(street);
        }

        int maxScore = 0;
        foreach (Candidate candidate in array)
        {
            SubjectScore[] subjectScores = candidate.SubjectScores;
            foreach (SubjectScore ss in subjectScores)
            {
                if (ss.SubjectName.Equals("Language") && maxScore < ss.Score)
                {
                    maxScore = ss.Score;
                }
            }
        }
        Console.WriteLine($"Max scor for Language: \n {maxScore}");
        


        //homework2 
        //Вывести на консоль всех сотрудников университета с описанием должностных обязанностей каждого
        //Вывести на консоль только всех преподавателей

        var marchenko = new Teacher(
            new Person("Aleksandr", "Marchenko", 
            new Adress("Minsk", "Mira", 23, 75)), 3488, 
            new Course("machine parts", "introduction to engineering"));
        
        var ivashko = new Teacher(
            new Person("Vadim", "Ivashko", 
            new Adress("Minsk", "Bechtereva", 8, 27)), 3456, 
            new Course("philosophy", "philosophy in economics"));
        
        var kozlov = new Teacher(
            new Person("Aleksei", "Kozlov", 
            new Adress("Zhodino", "Mashinostroitlei", 15, 33)), 8456, 
            new Course("engineering graphics", "design basics"));

        var astashevich = new DegreeTeacher(
            new Person("Dmitry", "Astashevich",
            new Adress("Minsk", "Volodarskogo", 56, 41)), 6678, 
            new Course("economics", "trade relations"), "Bachelor's degree", "assistant professor");
       
        var yakimovich = new DegreeTeacher(
            new Person("Oleg", "Yakimovich", 
            new Adress("Minsk", "Dzrginskogo", 34, 81)), 9974,
            new Course("theoretical mechanics", "kinematics"), "Master's degree", "Professor");
        
        var maslovskaya = new DegreeTeacher(
            new Person("Kristina", "Maslovskaya", 
            new Adress("Minsk", "Proletarskaya", 21, 55)), 3423, 
            new Course("material resistance", "deformation theory"), "Doctoral degree", "Professor");
        
        var svirid = new SupportStaff(
            new Person("Dmitry", "Svirid",
            new Adress("Minsk", "Umanskaya", 8, 5)), 4444, "mechanic");
       
        var saveliev = new SupportStaff(
            new Person("Nikolai", "Saveliev", 
            new Adress("Minsk", "Krasivaya", 4, 18)), 3534, "an electrician");
        
        var korneev = new SupportStaff(
            new Person("Andrei", "Korneev", 
            new Adress("Minsk", "Fabritsiusa", 56, 65)), 6006, "plumber");
        
        UniversityEmployee[] universityEmployees =
        {
            marchenko,
            ivashko,
            kozlov,
            astashevich,
            yakimovich,
            maslovskaya,
            svirid,
            saveliev,
            korneev
        };

        Console.WriteLine(" University employees: ");
        Console.WriteLine(("").PadRight(80, '-'));

        foreach (var UniversityEmployee in universityEmployees)
        {
            Console.WriteLine($"{UniversityEmployee.Person.FirstName} {UniversityEmployee.Person.LastName} {UniversityEmployee.GetOfficialDuties()}\n");
        }

        Console.WriteLine(" University teachers : ");
        Console.WriteLine(("").PadRight(80, '-'));

        foreach (var UniversityEmployee in universityEmployees)
        {
            if (UniversityEmployee is Teacher)
            {
                Console.WriteLine($"{UniversityEmployee.Person.FirstName} {UniversityEmployee.Person.LastName} {UniversityEmployee.GetOfficialDuties()}");
            }
        }
        

        //homework3
        //Создать и инициализировать объект типа University (ректор, юридический адрес, сотрудники, здания)

        Teacher bondarenko = new
           Teacher (new Person("Aleksandr", "Bondarenko ",
           new Adress("Minsk", "Lesnaya", 15, 18)), 4525,
           new Course("Math", "Theory"));
        
        Teacher golovko = new
           Teacher (new Person("Oleg", "Golovko ",
           new Adress("Minsk", "Svobody", 22, 14)), 2234,
           new Course("Teoretical Mechanic", "TMM"));

        SupportStaff kiselev = new
            SupportStaff (new Person("Anatoly", "Kiselev",
            new Adress("Zhodino", "Pobedy", 15, 12)), 4556, "Rector");

        UniversityEmployee[] employees =
        {
        bondarenko,
        golovko,
        kiselev
        };

        Room auxiliary = new
            (1, "Auxiliary room");
        Room lectureHall = new
            (2, "Lecture hall");
        Room laboratory = new
            (3, "Laboratory");
        Room suminarRoom = new
            (4, "Suminar room");

        Room[] RoomsBuilding1 =
        {
        laboratory,
        lectureHall,
        suminarRoom,
        auxiliary
        };

        Room[] RoomsBuilding2 =
        {
        laboratory,
        lectureHall,
        suminarRoom,
        auxiliary
        };

        Room[] RoomsBuilding3 =
        {
        laboratory,
        lectureHall,
        suminarRoom,
        auxiliary
        };

        AdressBuilding officialAdrss = new
            ("Minsk",
            "Matusevicha",
            22);
        AdressBuilding adressBuilding2 = new
            ("Minsk",
            "Matusevicha",
            23);
        AdressBuilding adressBuilding3 = new
            ("Minsk",
            "Matusevicha",
            24);

        Building building1 = new
            (RoomsBuilding1,
            officialAdrss,
            234);
        Building building2 = new
            (RoomsBuilding2,
            adressBuilding2,
            235);
        Building building3 = new
            (RoomsBuilding3,
            adressBuilding3,
            236);

        Building[] buildings =
        {
        building1,
        building2,
        building3
        };

        University university = new(
            kiselev,
            employees,
            buildings,
            officialAdrss);

        Console.WriteLine(university.Rector.Person.LastName);
        Console.ReadLine();
     
    }
  }
