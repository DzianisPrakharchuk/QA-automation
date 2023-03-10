using homework3;
using System;

//homework1
//Создать массив из 5 абитуриентов (Candidate), заполнить его 
//Вывести список всех улиц, на которых живут абитуриенты 

internal class Program
{
    private static void Main(string[] args)
    {
        var candidate1 = new Candidate(
            new Person("Aliaksei", "Kazlou", new Adress("Zhodino", "Mira", 15, 12)),
            new List<SubjectScore>
              {
              new( "Language", 8 ),
              new( "Math", 10 )
              });

       var candidate2 = new Candidate(
            new Person("Maksim", "Rubanau", new Adress("Minsk", "Aerodromnaya", 1, 22)),
            new List<SubjectScore>
              {
              new ("Language", 7),
              new ("Math", 9)
              });

        var candidate3 = new Candidate(
            new Person("Alesia", "Zabavskaia", new Adress("Minsk", "Matysevicha", 12, 16)),
            new List<SubjectScore>
              {
              new ("Language", 6),
              new ("Math", 7)
              });

        var candidate4 = new Candidate(
            new Person("Svetlana", "Zenkovich", new Adress("Minsk", "Krasivaya", 66, 31)),
            new List<SubjectScore>
              {
              new ("Language", 5),
              new ("Math", 9)
              });

        var candidate5 = new Candidate(
            new Person("Victor", "Acramchuk", new Adress("Minsk", "Pushkina", 18, 44)),
            new List<SubjectScore>
              {
              new ("Language", 4),
              new ("Math", 6)
              });

        var candidates = new List<Candidate>
        {
            candidate1,
            candidate2,
            candidate3,
            candidate4,
            candidate5
        };
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine(" Streets where students live: ");
       

        foreach (var candidate in candidates)
        {
            string street = candidate.Person.Adress.Street;
            Console.WriteLine(street);
        }

        int maxScore = 0;
        foreach (var candidate in candidates)
        {
            var subjectScores = candidate.SubjectScores;
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
            new Person("Aleksandr", "Marchenko", new Adress("Minsk", "Mira", 23, 75)),
            3488,
            new Course("machine parts", "introduction to engineering"));

        var ivashko = new Teacher(
            new Person("Vadim", "Ivashko", new Adress("Minsk", "Bechtereva", 8, 27)), 
            3456,
            new Course("philosophy", "philosophy in economics"));

        var kozlov = new Teacher(
            new Person("Aleksei", "Kozlov", new Adress("Zhodino", "Mashinostroitlei", 15, 33)), 
            8456,
            new Course("engineering graphics", "design basics"));

        var astashevich = new DegreeTeacher(
            new Person("Dmitry", "Astashevich", new Adress("Minsk", "Volodarskogo", 56, 41)),
            6678,
            new Course("economics", "trade relations"),
            "Bachelor's degree",
            "assistant professor");

        var yakimovich = new DegreeTeacher(
            new Person("Oleg", "Yakimovich", new Adress("Minsk", "Dzrginskogo", 34, 81)),
            9974,
            new Course("theoretical mechanics", "kinematics"),
            "Master's degree",
            "Professor");

        var maslovskaya = new DegreeTeacher(
            new Person("Kristina", "Maslovskaya", new Adress("Minsk", "Proletarskaya", 21, 55)),
            3423,
            new Course("material resistance", "deformation theory"),
            "Doctoral degree",
            "Professor");

        var svirid = new SupportStaff(
            new Person("Dmitry", "Svirid", new Adress("Minsk", "Umanskaya", 8, 5)),
            4444,
            "mechanic");

        var saveliev = new SupportStaff(
            new Person("Nikolai", "Saveliev", new Adress("Minsk", "Krasivaya", 4, 18)), 
            3534,
            "an electrician");

        var korneev = new SupportStaff(
            new Person("Andrei", "Korneev", new Adress("Minsk", "Fabritsiusa", 56, 65)),
            6006,
            "plumber");

        var universityEmployees = new List<UniversityEmployee>
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
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine(" University employees: ");
        

        foreach (var UniversityEmployee in universityEmployees)
        {
            Console.WriteLine($"{UniversityEmployee.Person.FirstName} {UniversityEmployee.Person.LastName} {UniversityEmployee.GetOfficialDuties()}\n");
        }
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine(" University teachers : ");
        

        foreach (var UniversityEmployee in universityEmployees)
        {
            if (UniversityEmployee is Teacher)
            {
                Console.WriteLine($"{UniversityEmployee.Person.FirstName} {UniversityEmployee.Person.LastName} {UniversityEmployee.GetOfficialDuties()}");
            }
        }


        //homework3
        //Создать и инициализировать объект типа University (ректор, юридический адрес, сотрудники, здания)

        var bondar = new
           Teacher(new Person("Aleks", "Bondar",
           new Adress("Minsk", "Lesnaya", 15, 18)), 4525,
           new Course("Math", "Theory"));

        var golovkoO = new
           Teacher(new Person("Oleg", "Golovko ",
           new Adress("Minsk", "Svobody", 22, 14)), 2234,
           new Course("Teoretical Mechanic", "TMM"));

        var golovkoI = new
           Teacher(new Person("Ivan", "Golovko ",
           new Adress("Minsk", "Pravdy", 12, 11)), 2134,
           new Course("Byology", "Theory"));


        var kiselev = new
            SupportStaff(new Person("Anatoly", "Kiselev",
            new Adress("Zhodino", "Pobedy", 15, 12)), 4556, "Rector");

        var employees = new List<UniversityEmployee>
        {
        bondar,
        golovkoO,
        kiselev,
        golovkoI
        };



        var officialAdrss = new AdressBuilding
            ("Minsk",
            "Matusevicha",
            22);
        var adressBuilding2 = new AdressBuilding
            ("Minsk",
            "Matusevicha",
            23);
        var adressBuilding3 = new AdressBuilding
            ("Minsk",
            "Matusevicha",
            24);

        var building1 = new Building(
            new List<Room>{
              new(1, "Auxiliary room"),
              new(2, "Lecture hall"),
              new(5, "Laboratory"),
              new(4, "Suminar room")}, 
            officialAdrss,
            234);

        var building2 = new Building(
            new List<Room>{
              new(1, "Laboratory"),
              new(3, "Lecture hall"),
              new(5, "Lecture hall"),
              new(2, "Suminar room")},
            adressBuilding2,
            235);

        var building3 = new Building(
            new List<Room>{
              new(3, "Auxiliary room"),
              new(9, "Lecture hall"),
              new(5, "Laboratory"),
              new(7, "Lecture hall")}, 
            adressBuilding3,
            236);

        var buildings = new List<Building>
        {
        building1,
        building2,
        building3
        };

        var university = new University(
            kiselev,
            employees,
            buildings,
            officialAdrss);

        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine(university.Rector.Person.LastName);
        Console.ReadLine();


        //homework4
        //Для всех сущностей проекта, использующих  массивы, перейти к использованию  List
        //homework5
        //5.1 Вывести на экран всех сотрудников университета с фамилией,//начинающейся на определенную букву (по выбору).
        //Данный список должен быть отсортирован поTaxId сотрудника 
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine("Lastname start with S:");
        var selectedEmployee = new List<UniversityEmployee>();
        selectedEmployee = universityEmployees
            .Where(p => p.Person.LastName.StartsWith("S"))
            .OrderBy(p => p.TaxId)
            .ToList();

        foreach (var employee in selectedEmployee)
        {
            Console.WriteLine($"{employee.Person.LastName} {employee.TaxId}");
        }
        //5.2Вывести на экран всех преподавателей университета, читающих определенный курс  (по выбору., один и тот
        //же курс может читаться несколькими преподавателями).

        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine("Teachers  reading a course in theoretical mechanics:");
        var courseEmployee = new List<UniversityEmployee>();
        var courseTeachers = universityEmployees
             .OfType<Teacher>()
             .Where(p => p.Course.NameCourse == "theoretical mechanics")
             .ToList();

        foreach (var employee in courseTeachers)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName}");
        }
        //5.3 Вывести на экран TaxID и должностные обязанности каждого сотрудника (только эту информацию)
        Console.WriteLine("TaxId and responsibilities:");

        var SortResponsibilitiesList = employees
            .Select(universityEmployee => universityEmployee.TaxId + " " +
                universityEmployee.GetOfficialDuties())
            .ToList();

        foreach (var taxIdResponsibilities in SortResponsibilitiesList)
        {
            Console.WriteLine(taxIdResponsibilities);
        }
        //5.4 Вывести на экран адреса всех зданий, в который есть комната с определенным номером (по выбору)
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine("Buildings with number room 3:");

        var SortBuildings = buildings
            .Where(p => p.Rooms.Any(x => x.RoomNumber == 3));
       
        foreach (var building in SortBuildings)
        {
            Console.WriteLine($"{building.AddressBulding.City} {building.AddressBulding.Street} {building.AddressBulding.BuildingNumber}");
        }

        //5.5 Вывести на экран адрес здания с максимальным количеством комнат в нем
        Console.WriteLine("".PadRight(80, '-'));
        Console.WriteLine("Building with  maximum count of rooms:");
        var maxRoomCount = buildings.MaxBy(x => x.Rooms.Count)?.Rooms.Count;

        var largestBuildings = buildings
            .Where(p => p.Rooms.Count == maxRoomCount);
        
        foreach (Building building in largestBuildings)
        {
            Console.WriteLine($"{building.AddressBulding.City} {building.AddressBulding.Street} {building.AddressBulding.BuildingNumber}");
        }
        Console.WriteLine("".PadRight(80, '-'));

        //5.6 Вывести на экран самую часто встречающуюся фамилию сотрудника, и число таких сотрудников

        Console.WriteLine("The most popular lastname of the employee, and quantity employees:");
        var mostPopularLastName = employees
            .GroupBy(p => p.Person.LastName)
            .MaxBy(x => x.Count());

        Console.WriteLine($"{mostPopularLastName.Key} {mostPopularLastName.Count()}");

        // 6.1 Реализовать проверку TaxId в конструкторе Employee, если TaxId меньше 0 - выбрасывать ArgumentException  
        try
        {
           var semenov = new Teacher(
               new Person("Petr", "Semenov ", new Adress("Minsk", "Prytyckogo", 11, 19)),
               -1234,
               new Course("Informatics", "introduction"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("".PadRight(80, '-'));
            //6.2 Реализовать проверку длины имени и фамилии сотрудника, если суммарная длина имени и фамилии больше
            //15 символов- выбрасывать ArgumentException  
        }
            try
            {

            Teacher pekarskij = new Teacher(
                new Person("Pavellllllll", "Pekarskij ", new Adress("Minsk", "Matusevicha", 1, 9)),
                5555,
                new Course("Informatics", "QA"));

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        Console.WriteLine("".PadRight(80, '-'));

        //6.3 *Отсортировать список сотрудников по суммарной длине имени и фамилии по убыванию тремя способами:
        //методом Sort():

        employees.Sort();
        employees.Reverse();

        foreach (var x in employees)
        {

            Console.WriteLine($"{x.Person.FirstName}  {x.Person.LastName}");
        }

        Console.WriteLine("".PadRight(80, '-'));

        //методом LINQ OrderBy().

        var SortSummaryName = employees
            .OrderByDescending(n => n.Person.SummaryNameLength());
            

        foreach (var universityEmployee in SortSummaryName)
        {
            Console.WriteLine($"{universityEmployee.Person.FirstName} {universityEmployee.Person.LastName}");
        }
        Console.WriteLine("".PadRight(80, '-'));

        //методом Sort(IComparer) (реализовать интерфейс IComparable в классе Employee):
        employees
            .Sort((x, y) => (x.Person.SummaryNameLength())
            .CompareTo((y.Person.SummaryNameLength())));
        employees.Reverse();

        foreach (var e in employees)
        {
            Console.WriteLine($"{e.Person.FirstName}  {e.Person.LastName}");
        }
    }
}