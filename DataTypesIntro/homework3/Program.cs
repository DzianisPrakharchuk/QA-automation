using System;

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
            new List<SubjectScore>
            {
            new( "Language", 8 ),
            new( "Math", 10 )
            });

        Candidate candidate2 = new(
            new Person("Maksim", "Rubanau",
            new Adress("Minsk", "Aerodromnaya", 1, 22)),
            new List<SubjectScore>
            {
            new ("Language", 7),
            new ("Math", 9)
            });

        Candidate candidate3 = new(
            new Person("Alesia", "Zabavskaia",
            new Adress("Minsk", "Matysevicha", 12, 16)),
            new List<SubjectScore>
            {
            new ("Language", 6),
            new ("Math", 7)
            });

        Candidate candidate4 = new(
            new Person("Svetlana", "Zenkovich",
            new Adress("Minsk", "Krasivaya", 66, 31)),
            new List<SubjectScore>
            {
            new ("Language", 5),
            new ("Math", 9)
            });

        Candidate candidate5 = new(
            new Person("Victor", "Acramchuk",
            new Adress("Minsk", "Pushkina", 18, 44)),
            new List<SubjectScore>
            {
            new ("Language", 4),
            new ("Math", 6)
            });

        List<Candidate> candidates= new List<Candidate>
        {
            candidate1,
            candidate2,
            candidate3,
            candidate4,
            candidate5
        };

        Console.WriteLine(" Streets where students live: ");
        Console.WriteLine(("").PadRight(30, '-'));

        foreach (Candidate candidate in candidates)
        {
            string street = candidate.Person.Adress.Street;
            Console.WriteLine(street);
        }

        int maxScore = 0;
        foreach (Candidate candidate in candidates)
        {
            List<SubjectScore> subjectScores = candidate.SubjectScores;
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
        
        List<UniversityEmployee> universityEmployees = new List<UniversityEmployee>
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
        
        Teacher golovkoO = new
           Teacher (new Person("Oleg", "Golovko ",
           new Adress("Minsk", "Svobody", 22, 14)), 2234,
           new Course("Teoretical Mechanic", "TMM"));

        Teacher golovkoI = new
           Teacher(new Person("Ivan", "Golovko ",
           new Adress("Minsk", "Pravdy", 12, 11)), 2134,
           new Course("Byology", "Theory"));


        SupportStaff kiselev = new
            SupportStaff (new Person("Anatoly", "Kiselev",
            new Adress("Zhodino", "Pobedy", 15, 12)), 4556, "Rector");

        List<UniversityEmployee> employees = new List<UniversityEmployee>
        {
        bondarenko,
        golovkoO,
        golovkoI,
        kiselev
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

        Building building1 = new Building(new List<Room>{
            new(1, "Auxiliary room"), 
            new(2, "Lecture hall"),
            new(5, "Laboratory"),
            new(4, "Suminar room")}, officialAdrss, 234);
    
        Building building2 = new Building(new List<Room>{
            new(1, "Laboratory"),
            new(3, "Lecture hall"),
            new(5, "Lecture hall"),
            new(2, "Suminar room")}, adressBuilding2, 235);
        
        Building building3 = new Building(new List<Room>{
            new(3, "Auxiliary room"),
            new(9, "Lecture hall"),
            new(5, "Laboratory"), 
            new(7, "Lecture hall")}, adressBuilding3, 236);
        
        List<Building> buildings = new List<Building>
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


//homework4
//Для всех сущностей проекта, использующих  массивы, перейти к использованию  List
//homework5
//5.1 Вывести на экран всех сотрудников университета с фамилией,//начинающейся на определенную букву (по выбору).
//Данный список должен быть отсортирован поTaxId сотрудника 

        Console.WriteLine("Lastname start with S:");
        var selectedEmployee = new List<UniversityEmployee>();
        selectedEmployee = universityEmployees
            .Where(p => p.Person.LastName.StartsWith("S"))
            .OrderBy(p => p.TaxId)
            .ToList();

        foreach (UniversityEmployee employee in selectedEmployee)
        {
            Console.WriteLine($"{employee.Person.LastName} {employee.TaxId}");
        }
        //5.2Вывести на экран всех преподавателей университета, читающих определенный курс  (по выбору., один и тот
        //же курс может читаться несколькими преподавателями).

        Console.WriteLine("Teachers  reading a course in theoretical mechanics:");
        var courseEmployee = new List<UniversityEmployee>();
        courseEmployee = universityEmployees
             .Where(p => p is Teacher teacher && teacher.Course.NameCourse == "theoretical mechanics")
    .ToList();

        foreach (UniversityEmployee employee in courseEmployee)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName}");
        }
//5.3 Вывести на экран TaxID и должностные обязанности каждого сотрудника (только эту информацию)
        Console.WriteLine("TaxId and responsibilities:");

        var SortResponsibilitiesList = employees
            .Select(universityEmployee => universityEmployee.TaxId.ToString() + " " +
                universityEmployee.GetOfficialDuties())
            .ToList();

        foreach (var taxIdResponsibilities in SortResponsibilitiesList)
        {
            Console.WriteLine(taxIdResponsibilities);
        }
        //5.4 Вывести на экран адреса всех зданий, в который есть комната с определенным номером (по выбору)

        Console.WriteLine("Buildings with number room 3:");

        var SortBuildings = new List<Building>();

        SortBuildings = buildings
            .Where(p => p.Rooms.
                Select(room => room.RoomNumber)
                .Any(x => x == 3))
            .ToList();

        foreach (Building building in SortBuildings)
        {
            Console.WriteLine($"{building.AddressBulding.City} {building.AddressBulding.Street} {building.AddressBulding.BuildingNumber}");
        }

        //5.5 Вывести на экран адрес здания с максимальным количеством комнат в нем
        Console.WriteLine("building with  maximum count of rooms:");
        var largestBuildings = buildings

            .Where(p => p.Rooms.Count == buildings.Select(x => x.Rooms.Count)
            .Max());

        foreach (Building building in largestBuildings)
        {
            Console.WriteLine($"{building.AddressBulding.City} {building.AddressBulding.Street} {building.AddressBulding.BuildingNumber}");
        }

        //5.6 Вывести на экран самую часто встречающуюся фамилию сотрудника, и число таких сотрудников
        Console.WriteLine("the most popular lastname of the employee, and quantity employees:");
        var mostPopularLastName = employees
            .GroupBy(p => p.Person.LastName)
            .MaxBy(x => x.Count());

        Console.WriteLine($"{mostPopularLastName.Key} {mostPopularLastName.Count()}");

    }
}